using Microsoft.Extensions.Configuration;

namespace TwitchVrcAvatarOSC
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddHostedService<TwitchBot>();
            services.AddHostedService<OscActions>();
            services.AddHostedService<Updater>();
            services.AddHostedService<Streamlabs>();

            services.AddControllersWithViews();
        }

        public void Configure(IApplicationBuilder app, IHostEnvironment env)
        {
            app.UseRouting();

            app.UseEndpoints(ends =>
            {
                ends.MapControllers();
            });
        }
    }
}
