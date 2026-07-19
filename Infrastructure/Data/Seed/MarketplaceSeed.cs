public static class MarketplaceSeed {
    public static async Task SeedAsync(AppDbContext context)
    {
        if (!context.Marketplace.Any())
        {
            context.Marketplace.AddRange(
                new Marketplace { Name = "Mercado Livre", DefaultQueryUrl = "lista.mercadolivre.com.br/" },
                new Marketplace { Name = "Shopee", DefaultQueryUrl = "shopee.com.br/search" }
            );

            await context.SaveChangesAsync();
        }
    }

}