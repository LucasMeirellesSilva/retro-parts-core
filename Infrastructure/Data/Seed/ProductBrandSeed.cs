public static class ProductBrandSeed {
    public static async Task SeedAsync(AppDbContext context)
    {
        if (!context.ProductBrand.Any())
        {
            context.ProductBrand.AddRange(
                new ProductBrand { Name = "Genérico", Slug = SlugGenerator.Generate("Genérico") },
                new ProductBrand { Name = "Honda", Slug = SlugGenerator.Generate("Honda") },
                new ProductBrand { Name = "Yamaha", Slug = SlugGenerator.Generate("Yamaha") },
                new ProductBrand { Name = "Agrale", Slug = SlugGenerator.Generate("Agrale") },
                new ProductBrand { Name = "Cagiva", Slug = SlugGenerator.Generate("Cagiva") },
                new ProductBrand { Name = "Suzuki", Slug = SlugGenerator.Generate("Suzuki") },
                new ProductBrand { Name = "Inago", Slug = SlugGenerator.Generate("Inago") },
                new ProductBrand { Name = "Metal Leve", Slug = SlugGenerator.Generate("Metal Leve") },
                new ProductBrand { Name = "KMP", Slug = SlugGenerator.Generate("KMP") },
                new ProductBrand { Name = "Toko", Slug = SlugGenerator.Generate("Toko") },
                new ProductBrand { Name = "Gold Deer", Slug = SlugGenerator.Generate("Gold Deer") },
                new ProductBrand { Name = "Audax", Slug = SlugGenerator.Generate("Audax") },
                new ProductBrand { Name = "CPL", Slug = SlugGenerator.Generate("CPL") },
                new ProductBrand { Name = "Standart W", Slug = SlugGenerator.Generate("Standart W") },
                new ProductBrand { Name = "Trilha", Slug = SlugGenerator.Generate("Trilha") },
                new ProductBrand { Name = "KS (Kolbenschmidt)", Slug = SlugGenerator.Generate("KS (Kolbenschmidt)") },
                new ProductBrand { Name = "Cofap", Slug = SlugGenerator.Generate("Cofap") },
                new ProductBrand { Name = "Rocatti", Slug = SlugGenerator.Generate("Rocatti") },
                new ProductBrand { Name = "Melc", Slug = SlugGenerator.Generate("Melc") },
                new ProductBrand { Name = "Eninco", Slug = SlugGenerator.Generate("Eninco") },
                new ProductBrand { Name = "Pro Tork", Slug = SlugGenerator.Generate("Pro Tork") },
                new ProductBrand { Name = "Guide Win", Slug = SlugGenerator.Generate("Guide Win") },
                new ProductBrand { Name = "Auco", Slug = SlugGenerator.Generate("Auco") },
                new ProductBrand { Name = "Metagal", Slug = SlugGenerator.Generate("Metagal") },
                new ProductBrand { Name = "WW3", Slug = SlugGenerator.Generate("WW3") },
            );

            await context.SaveChangesAsync();
        }
    }

}