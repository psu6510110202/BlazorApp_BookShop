using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using OnlyBookShop.Data;

namespace OnlyBookShop
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
                });

            builder.Services.AddMauiBlazorWebView();

#if DEBUG
    		builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif

            builder.Services.AddSingleton<WeatherForecastService>();
            builder.Services.AddDbContextFactory<BookDbContext>(opt =>
            {
                var dbPath = Path.Combine(FileSystem.AppDataDirectory, $"{nameof(BookDbContext)}.db");
                opt.UseSqlite($"Data Source={dbPath}");
                using var dbcontext = new BookDbContext(opt.Options);
                if (dbcontext.Database.EnsureCreated())
                    dbcontext.SaveChanges();
            });
            return builder.Build();
        }
    }
}
