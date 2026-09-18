using Microsoft.EntityFrameworkCore;

public static class ProductBrandSeed
{
    public static void Configure(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ProductBrand>().HasData(
            new ProductBrand { Id = 1, Name = "Agrale", Slug = SlugGenerator.Generate("Agrale") },
            new ProductBrand { Id = 2, Name = "Auco", Slug = SlugGenerator.Generate("Auco") },
            new ProductBrand { Id = 3, Name = "Audax", Slug = SlugGenerator.Generate("Audax") },
            new ProductBrand { Id = 4, Name = "Cagiva", Slug = SlugGenerator.Generate("Cagiva") },
            new ProductBrand { Id = 5, Name = "Cofap", Slug = SlugGenerator.Generate("Cofap") },
            new ProductBrand { Id = 6, Name = "CPL", Slug = SlugGenerator.Generate("CPL") },
            new ProductBrand { Id = 7, Name = "Eninco", Slug = SlugGenerator.Generate("Eninco") },
            new ProductBrand { Id = 8, Name = "Gold Deer", Slug = SlugGenerator.Generate("Gold Deer") },
            new ProductBrand { Id = 9, Name = "Genérico", Slug = SlugGenerator.Generate("Genérico") },
            new ProductBrand { Id = 10, Name = "Guide Win", Slug = SlugGenerator.Generate("Guide Win") },
            new ProductBrand { Id = 11, Name = "Honda", Slug = SlugGenerator.Generate("Honda") },
            new ProductBrand { Id = 12, Name = "Inago", Slug = SlugGenerator.Generate("Inago") },
            new ProductBrand { Id = 13, Name = "Kim", Slug = SlugGenerator.Generate("Kim") },
            new ProductBrand { Id = 14, Name = "KMP", Slug = SlugGenerator.Generate("KMP") },
            new ProductBrand { Id = 15, Name = "KS (Kolbenschmidt)", Slug = SlugGenerator.Generate("KS (Kolbenschmidt)") },
            new ProductBrand { Id = 16, Name = "Melc", Slug = SlugGenerator.Generate("Melc") },
            new ProductBrand { Id = 17, Name = "Metal Leve", Slug = SlugGenerator.Generate("Metal Leve") },
            new ProductBrand { Id = 18, Name = "Metagal", Slug = SlugGenerator.Generate("Metagal") },
            new ProductBrand { Id = 19, Name = "Pro Tork", Slug = SlugGenerator.Generate("Pro Tork") },
            new ProductBrand { Id = 20, Name = "Rocatti", Slug = SlugGenerator.Generate("Rocatti") },
            new ProductBrand { Id = 21, Name = "Rik", Slug = SlugGenerator.Generate("Rik") },
            new ProductBrand { Id = 22, Name = "Standart W", Slug = SlugGenerator.Generate("Standart W") },
            new ProductBrand { Id = 23, Name = "Suloy", Slug = SlugGenerator.Generate("Suloy") },
            new ProductBrand { Id = 24, Name = "Suzuki", Slug = SlugGenerator.Generate("Suzuki") },
            new ProductBrand { Id = 25, Name = "Toko", Slug = SlugGenerator.Generate("Toko") },
            new ProductBrand { Id = 26, Name = "Trilha", Slug = SlugGenerator.Generate("Trilha") },
            new ProductBrand { Id = 27, Name = "WW3", Slug = SlugGenerator.Generate("WW3") },
            new ProductBrand { Id = 28, Name = "Yamaha", Slug = SlugGenerator.Generate("Yamaha") }
        );
    }
}
