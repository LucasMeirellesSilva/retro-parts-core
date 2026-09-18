using Microsoft.EntityFrameworkCore;

public static class MotorcycleModelSeed
{
    public static void Configure(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<MotorcycleModel>().HasData(
            // Honda
            new MotorcycleModel { Id = 1, Name = "CG 125", BrandId = 1 },
            new MotorcycleModel { Id = 2, Name = "ML 125", BrandId = 1 },
            new MotorcycleModel { Id = 3, Name = "Turuna 125", BrandId = 1 },
            new MotorcycleModel { Id = 4, Name = "CB 400", BrandId = 1 },
            new MotorcycleModel { Id = 5, Name = "XL 250", BrandId = 1 },
            new MotorcycleModel { Id = 6, Name = "CB 450", BrandId = 1 },
            new MotorcycleModel { Id = 7, Name = "XL 125", BrandId = 1 },
            new MotorcycleModel { Id = 8, Name = "XLX 250", BrandId = 1 },
            new MotorcycleModel { Id = 9, Name = "XLX 350", BrandId = 1 },
            new MotorcycleModel { Id = 10, Name = "Today 125", BrandId = 1 },
            new MotorcycleModel { Id = 11, Name = "NX 150", BrandId = 1 },
            new MotorcycleModel { Id = 12, Name = "CBX 150", BrandId = 1 },
            new MotorcycleModel { Id = 13, Name = "NX 350", BrandId = 1 },
            new MotorcycleModel { Id = 14, Name = "C100", BrandId = 1 },
            new MotorcycleModel { Id = 15, Name = "NX 200", BrandId = 1 },
            new MotorcycleModel { Id = 16, Name = "CBX 200", BrandId = 1 },
            new MotorcycleModel { Id = 17, Name = "XR 200", BrandId = 1 },
            new MotorcycleModel { Id = 18, Name = "XLR 125", BrandId = 1 },
            new MotorcycleModel { Id = 19, Name = "CB 500", BrandId = 1 },
            new MotorcycleModel { Id = 20, Name = "NX 400", BrandId = 1 },
            new MotorcycleModel { Id = 21, Name = "CBX 250", BrandId = 1 },
            new MotorcycleModel { Id = 22, Name = "XR 250", BrandId = 1 },
            new MotorcycleModel { Id = 23, Name = "NXR 125", BrandId = 1 },
            new MotorcycleModel { Id = 24, Name = "NXR 150", BrandId = 1 },
            new MotorcycleModel { Id = 25, Name = "CG 150", BrandId = 1 },
            new MotorcycleModel { Id = 26, Name = "Biz 125", BrandId = 1 },
            new MotorcycleModel { Id = 27, Name = "Pop 100", BrandId = 1 },
            new MotorcycleModel { Id = 28, Name = "Biz 100", BrandId = 1 },

            // Yamaha
            new MotorcycleModel { Id = 29, Name = "RD 50", BrandId = 2 },
            new MotorcycleModel { Id = 30, Name = "RD 75", BrandId = 2 },
            new MotorcycleModel { Id = 31, Name = "RX 80", BrandId = 2 },
            new MotorcycleModel { Id = 32, Name = "RX 125", BrandId = 2 },
            new MotorcycleModel { Id = 33, Name = "TT 125", BrandId = 2 },
            new MotorcycleModel { Id = 34, Name = "RX 180", BrandId = 2 },
            new MotorcycleModel { Id = 35, Name = "DT 180", BrandId = 2 },
            new MotorcycleModel { Id = 36, Name = "RDZ 125", BrandId = 2 },
            new MotorcycleModel { Id = 37, Name = "MX 180", BrandId = 2 },
            new MotorcycleModel { Id = 38, Name = "RD 125", BrandId = 2 },
            new MotorcycleModel { Id = 39, Name = "RD 350", BrandId = 2 },
            new MotorcycleModel { Id = 40, Name = "RD 135", BrandId = 2 },
            new MotorcycleModel { Id = 41, Name = "RDZ 135", BrandId = 2 },
        );
    }
}
