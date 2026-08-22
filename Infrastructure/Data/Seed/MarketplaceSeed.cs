public static class MarketplaceSeed {
    public static async Task SeedAsync(AppDbContext context)
    {
        if (!context.Marketplace.Any())
        {
            context.Marketplace.AddRange(
                new Marketplace { Name = "Mercado Livre" },
                new Marketplace { Name = "Shopee" }
            );

            await context.SaveChangesAsync();
        }
    }

}