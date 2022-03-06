using System.IO.Compression;
using System.Reflection;

namespace TwitchVrcAvatarOSC.Services
{
    public class Updater : BackgroundService
    {
        public string URL => "https://raw.githubusercontent.com/Killers0992/TwitchVrcAvatarOSC/master/TwitchVrcAvatarOSC/version.json";
        HttpClient _client = new HttpClient();
        bool received;

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            if (File.Exists("./old_TwitchVrcAvatarOSC.exe"))
                File.Delete("./old_TwitchVrcAvatarOSC.exe");

            await Task.Delay(5000);
            while (true)
            {
                Logger.Info("Updater", "Check if update is avaliable...", Color.White, Color.White);
                var result = await _client.GetAsync(URL);
                if (!result.IsSuccessStatusCode)
                {
                    Logger.Info("Updater", "Failed getting current version from website! ( network failure )", Color.White, Color.White);
                    await Task.Delay(15000);
                    continue;
                }
                var content = await result.Content.ReadAsStringAsync();

                var versionObject = JsonConvert.DeserializeObject<CurrentVersion>(content);

                if (versionObject.Version == null)
                {
                    Logger.Info("Updater", "Remote version is invalid!", Color.White, Color.White);
                    await Task.Delay(15000);
                    continue;
                }

                if (Version.TryParse(CurrentVersion.Instance.Version, out Version currentVersion))
                {
                    if (Version.TryParse(versionObject.Version, out Version newVersion))
                    {
                        if (currentVersion.CompareTo(newVersion) < 0)
                        {
                            if (!received)
                            {
                                received = true;
                                Logger.Info("Updater", $"New version \"{versionObject.Version}\" is avaliable!", Color.White, Color.White);
                                if (versionObject.Changelog.Length > 0)
                                {
                                    Logger.Info("Updater", $"Changelogs:", Color.White, Color.White);
                                    foreach (var change in versionObject.Changelog)
                                    {
                                        Logger.Info("Updater", $" - {change}", Color.White, Color.White);
                                    }
                                }
                            }

                            Logger.Info("Updater", $"Application will be updated in 5 seconds.", Color.White, Color.White);
                            await Task.Delay(5000);
                            var time = new Stopwatch();
                            time.Start();
                            Logger.Info("Updater", $"Start downloading file...", Color.White, Color.White);
                            result = await _client.GetAsync($"https://github.com/Killers0992/TwitchVrcAvatarOSC/releases/download/{versionObject.Version}/TwitchBot.zip");
                            if (result.IsSuccessStatusCode)
                            {
                                var bytes = await result.Content.ReadAsByteArrayAsync();
                                File.WriteAllBytes("./TwitchBot.zip", bytes);
                                time.Stop();
                                Logger.Info("Updater", $"Downloaded file in {(int)time.Elapsed.TotalSeconds} seconds!", Color.White, Color.White);
                                string currentPath = Path.Combine(AppContext.BaseDirectory, $"TwitchVrcAvatarOSC.exe");
                                string archivePath = Path.Combine(AppContext.BaseDirectory, $"old_TwitchVrcAvatarOSC.exe");
                                File.Move(currentPath, archivePath);

                                using (ZipArchive archive = ZipFile.OpenRead("./TwitchBot.zip"))
                                {
                                    foreach (ZipArchiveEntry entry in archive.Entries.Where(e => e.FullName.Contains("a")))
                                    {
                                        entry.ExtractToFile(currentPath);
                                    }
                                }
                                File.Delete("./TwitchBot.zip");
                                time.Stop();
                                ProcessStartInfo startInfo = new ProcessStartInfo(currentPath);
                                Process.Start(startInfo);
                                Process.GetCurrentProcess().Kill();
                            }
                            else
                            {
                                time = null;
                                Logger.Info("Updater", $"Remote file for version \"{versionObject.Version}\" is invalid!", Color.White, Color.White);
                                await Task.Delay(15000);
                                continue;
                            }
                        }
                        else
                        {
                            Logger.Info("Updater", "No updates avaliable.", Color.White, Color.White);
                        }
                    }
                }
                await Task.Delay(30000);
            }
        }
    }
}
