public static class SeedExtensions
{
    public static async Task SeedDatabaseAsync(this IServiceProvider services)
    {
        using var scope = services.CreateScope();

        var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();

        await MarketplaceSeed.SeedAsync(context);
        await ProductBrandSeed.SeedAsync(context);
        await MeasurementTypeSeed.SeedAsync(context);
    }
}