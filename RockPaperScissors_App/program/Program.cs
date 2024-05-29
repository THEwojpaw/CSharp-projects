using KamienPapierNozyce_App;
using KamienPapierNozyce_App.Services;
using KamienPapierNozyce_App.Services.Abstraction;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace KamienPapierNozyce
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            Application.Run(ServiceProvider.GetRequiredService<GameInitialization>());
        }

        public static IServiceProvider ServiceProvider { get; private set; }
        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {
                    services.AddSingleton<IPointCounterService, PointCounterService>();
                    services.AddTransient<GameInitialization>();
                });
        }
    }
}
