using MachinePark.Api.Data;

namespace MachinePark.Api.Extensions
{
    public static class ApplicationBuilderExtensions
    {
        public static async Task<IApplicationBuilder> SeedDataAsync(this IApplicationBuilder app)
        {
            using (var scope = app.ApplicationServices.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<ApiContext>();

                // Uncomment these two for a fresh database installation with SeedData.
                // await context.Database.EnsureDeletedAsync();
                // await context.Database.MigrateAsync();

                try
                {
                    await SeedData.Init(context);
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
            return app;
        }
    }
}
