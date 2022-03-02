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
                Logger.Log("Updater", "Check if update is avaliable...");
                var result = await _client.GetAsync(URL);
                if (!result.IsSuccessStatusCode)
                {
                    Logger.Log("Updater", "Failed getting current version from website! ( network failure )");
                    await Task.Delay(15000);
                    continue;
                }
                var content = await result.Content.ReadAsStringAsync();

                var versionObject = JsonConvert.DeserializeObject<CurrentVersion>(content);

                if (versionObject.Version == null)
                {
                    Logger.Log("Updater", "Remote version is invalid!");
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
                                Logger.Log("Updater", $"New version \"{versionObject.Version}\" is avaliable!");
                                if (versionObject.Changelog.Length > 0)
                                {
                                    Logger.Log("Updater", $"Changelogs:");
                                    foreach (var change in versionObject.Changelog)
                                    {
                                        Logger.Log("Updater", $" - {change}");
                                    }
                                }
                            }

                            Logger.Log("Updater", $"Application will be updated in 5 seconds.");
                            await Task.Delay(5000); 
                            result = await _client.GetAsync($"https://github.com/Killers0992/TwitchVrcAvatarOSC/releases/download/{versionObject.Version}/TwitchBot.zip");
                            if (result.IsSuccessStatusCode)
                            {
                                Logger.Log("Updater", $"Start downloading file...");
                                var time = new Stopwatch();
                                time.Start();
                                var bytes = await result.Content.ReadAsByteArrayAsync();
                                File.WriteAllBytes("./TwitchBot.zip", bytes);
                                time.Stop();
                                Logger.Log("Updater", $"Downloaded file in {(int)time.Elapsed.TotalSeconds} seconds!");
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
                                ProcessStartInfo startInfo = new ProcessStartInfo(currentPath);
                                Process.Start(startInfo);
                                Process.GetCurrentProcess().Kill();
                            }
                            else
                            {
                                Logger.Log("Updater", $"Remote file for version \"{versionObject.Version}\" is invalid!");
                                await Task.Delay(15000);
                                continue;
                            }
                        }
                        else
                        {
                            Logger.Log("Updater", "No updates avaliable.");
                        }
                    }
                }
                await Task.Delay(30000);
            }
        }
    }
}
