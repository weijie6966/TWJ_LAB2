using Microsoft.Extensions.Logging;
using TWJ_LAB2.ViewModels; // 新增
using TWJ_LAB2.Models;    // 新增
using TWJ_LAB2.Views;

namespace TWJ_LAB2
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

            // 注册 View 和 ViewModel 作为 Singleton 服务
            builder.Services.AddSingleton<Views.MainPage>();
            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<MainPageViewModel>();
            builder.Services.AddSingleton<PetDetails>();


#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}