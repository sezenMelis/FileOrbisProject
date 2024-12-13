using FileOrbisProject.ViewModels;
using Microsoft.Extensions.Logging;

namespace FileOrbisProject
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            builder.Services.AddSingleton<ClientPageViewModel>();
            builder.Services.AddSingleton<AddClientPageViewModel>();
#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
