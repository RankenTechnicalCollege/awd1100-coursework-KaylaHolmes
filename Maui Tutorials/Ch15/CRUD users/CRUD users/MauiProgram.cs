using Microsoft.Extensions.Logging;

namespace CRUD_users
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
            builder.Services.AddDbContext<DataContext>(
            Options =>
            {
                var dbPath = Path.Combine(FileSystem.AppDataDirectory, "user.db");
                Options.UserSqlite($"Data Source={dbPath}");

            }
            ); //Dependancy Injection for DataContext
#if DEBUG
    		builder.Logging.AddDebug();

            var app = builder.Build();

            using (var scope = app.Services.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<DataContext>();
                context.Database.EnsureCreated();

                if (!context.Users.Any(
                    new user { Name = "Alice" },
                    new user { Name = "Bob" },
                    new user { Name = "Charlie" }

                    );
                context.SaveChanges();


            }

            return app;
#endif

            // return builder.Build();

        }
    }
}
