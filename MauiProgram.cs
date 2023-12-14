using Microsoft.Extensions.Logging;

namespace Stezar_Alex_Lab7
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
                })

                .ConfigureEssentials(essentials =>
                {
                    essentials.UseMapServiceToken("tg0kziHas6PQT782hJNP~FNh56w99lvSI42pgZCOSxQ~AjaTeO_LFoh-SPmvzMuiQ5JowEnrce79qnQfiPpuJypAHDZF3lGiSVmq08V8ymJX");
                 });

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}