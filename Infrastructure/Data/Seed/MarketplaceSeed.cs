using Microsoft.EntityFrameworkCore;

public static class MarketplaceSeed
{
    public static void Configure(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Marketplace>().HasData(
            new Marketplace { Id = 1, Name = "Mercado Livre" },
            new Marketplace { Id = 2, Name = "Shopee" }
        );
    }
}
