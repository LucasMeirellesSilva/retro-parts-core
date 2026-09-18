using Microsoft.EntityFrameworkCore;

public static class MotorcycleBrandSeed
{
    public static void Configure(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<MotorcycleBrand>().HasData(
            new MotorcycleBrand { Id = 1, Name = "Honda", Slug = SlugGenerator.Generate("Honda") },
            new MotorcycleBrand { Id = 2, Name = "Yamaha", Slug = SlugGenerator.Generate("Yamaha") },
            new MotorcycleBrand { Id = 3, Name = "Agrale", Slug = SlugGenerator.Generate("Agrale") },
            new MotorcycleBrand { Id = 4, Name = "Suzuki", Slug = SlugGenerator.Generate("Suzuki") },
            new MotorcycleBrand { Id = 5, Name = "Shineray", Slug = SlugGenerator.Generate("Shineray") },
            new MotorcycleBrand { Id = 6, Name = "Kawasaki", Slug = SlugGenerator.Generate("Kawasaki") },
            new MotorcycleBrand { Id = 7, Name = "Dafra", Slug = SlugGenerator.Generate("Dafra") }
        );
    }
}
