public static class MarketplaceProductBrandSeed {
    public static async Task SeedAsync(AppDbContext context)
    {
        if (await context.MarketplaceProductBrand.AnyAsync()) return;

        var mlId = await context.Marketplace.Where(x => x.Name == "Mercado Livre").Select(x => x.Id).SingleAsync();
        var shopeeId = await context.Marketplace.Where(x => x.Name == "Shopee").Select(x => x.Id).SingleAsync();

        var kmpId = await context.ProductBrand.Where(x => x.Name == "KMP").Select(x => x.Id).SingleAsync();

        context.MarketplaceProductBrand.AddRange(
            new MarketplaceProductBrand { Type = "absolute" },
            new MarketplaceProductBrand { Type = "oversize" }
        );

        await context.SaveChangesAsync();
    }

}