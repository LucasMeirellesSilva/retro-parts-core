public static class MotorcycleBrandSeed {
    public static async Task SeedAsync(AppDbContext context)
    {
        if (!context.MotorcycleBrand.Any())
        {
            context.MotorcycleBrand.AddRange(
                new MotorcycleBrand { Name = "Honda", Slug = SlugGenerator.Generate("Honda") },
                new MotorcycleBrand { Name = "Yamaha", Slug = SlugGenerator.Generate("Yamaha") },
                new MotorcycleBrand { Name = "Agrale", Slug = SlugGenerator.Generate("Agrale") },
                new MotorcycleBrand { Name = "Suzuki", Slug = SlugGenerator.Generate("Suzuki") },
                new MotorcycleBrand { Name = "Shineray", Slug = SlugGenerator.Generate("Shineray") },
                new MotorcycleBrand { Name = "Kawasaki", Slug = SlugGenerator.Generate("Kawasaki") },
                new MotorcycleBrand { Name = "Dafra", Slug = SlugGenerator.Generate("Dafra") },
            );

            await context.SaveChangesAsync();
        }
    }

}