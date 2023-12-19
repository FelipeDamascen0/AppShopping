using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;
using AppShopping.Services;
using ZXing.Net.Maui.Controls;
using AppShopping.Storages;

namespace AppShopping
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder.UseMauiApp<App>().ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            })
            .UseMauiCommunityToolkit()
            .UseBarcodeReader()
            .UseMauiCommunityToolkitMediaElement();
            builder.Services.AddSingleton<TicketPreferenceStorage>();
            builder.Services.AddSingleton<StoreService>();
            builder.Services.AddSingleton<RestaurantsService>();
            builder.Services.AddSingleton<CinemaService>();
            builder.Services.AddSingleton<TicketService>();
#if DEBUG
            builder.Logging.AddDebug();
#endif
            return builder.Build();
        }
    }
}