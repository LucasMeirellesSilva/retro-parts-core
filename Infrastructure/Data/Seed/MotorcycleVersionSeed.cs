using Microsoft.EntityFrameworkCore;

public static class MotorcycleVersionSeed
{
    public static void Configure(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<MotorcycleVersion>().HasData(
            new MotorcycleVersion { Id = 1, Alias = "CG Bolinha", ModelId = 1 },
            new MotorcycleVersion { Id = 2, ModelId = 1 },
            new MotorcycleVersion { Id = 3, Name = "Cargo", ModelId = 1 },
            new MotorcycleVersion { Id = 4, Name = "Titan", ModelId = 1 },
            new MotorcycleVersion { Id = 5, Name = "Titan KS", ModelId = 1 },
            new MotorcycleVersion { Id = 6, Name = "Titan KSE", ModelId = 1 },
            new MotorcycleVersion { Id = 7, Name = "Titan ES", ModelId = 1 },
            new MotorcycleVersion { Id = 8, Name = "Fan", ModelId = 1 },
            new MotorcycleVersion { Id = 9, Name = "Fan KS", ModelId = 1 },
            new MotorcycleVersion { Id = 10, Name = "Fan ES", ModelId = 1 },
            new MotorcycleVersion { Id = 11, Name = "Fan ESD", ModelId = 1 },

            new MotorcycleVersion { Id = 12, ModelId = 2 },

            new MotorcycleVersion { Id = 13, ModelId = 3 },

            new MotorcycleVersion { Id = 14, ModelId = 4 },
            new MotorcycleVersion { Id = 15, Name = "II", ModelId = 4 },

            new MotorcycleVersion { Id = 16, Alias = "XLR 250", ModelId = 5 },
            
            new MotorcycleVersion { Id = 17, ModelId = 6 },
            new MotorcycleVersion { Id = 18, Name = "Custom", ModelId = 6 },
            new MotorcycleVersion { Id = 19, Name = "DX", ModelId = 6 },
            new MotorcycleVersion { Id = 20, Name = "Esporte", ModelId = 6 },
            new MotorcycleVersion { Id = 21, Name = "TR", ModelId = 6 },

            new MotorcycleVersion { Id = 22, Alias = "XL 125S", ModelId = 7 },
            new MotorcycleVersion { Id = 23, Name = "Duty", ModelId = 7 },

            new MotorcycleVersion { Id = 24, ModelId = 8 },

            new MotorcycleVersion { Id = 25, ModelId = 9 },

            new MotorcycleVersion { Id = 26, ModelId = 10 },

            new MotorcycleVersion { Id = 27, ModelId = 11 },

            new MotorcycleVersion { Id = 28, Alias = "Aero", ModelId = 12 },

            new MotorcycleVersion { Id = 29, Alias = "Sahara", ModelId = 13 },

            new MotorcycleVersion { Id = 30, Name = "Dream", ModelId = 14 },
            new MotorcycleVersion { Id = 30, Name = "Biz ES", ModelId = 14 },
            new MotorcycleVersion { Id = 32, Name = "Biz+", ModelId = 14 },

            new MotorcycleVersion { Id = 33, ModelId = 15 },

            new MotorcycleVersion { Id = 34, Alias = "Strada", ModelId = 16 },

            new MotorcycleVersion { Id = 35, Alias = "XR 200R", ModelId = 17 },

            new MotorcycleVersion { Id = 36, ModelId = 18 },

            new MotorcycleVersion { Id = 37, ModelId = 19 },

            new MotorcycleVersion { Id = 38, Alias = "Falcon", ModelId = 20 },

            new MotorcycleVersion { Id = 39, Alias = "Twister", ModelId = 21 },

            new MotorcycleVersion { Id = 40, Alias = "Tornado", ModelId = 22 },

            new MotorcycleVersion { Id = 41, Alias = "Bros 125", ModelId = 23 },

            new MotorcycleVersion { Id = 42, Alias = "Bros 150", ModelId = 24 },

            new MotorcycleVersion { Id = 43, Name = "Titan KS", ModelId = 25 },
            new MotorcycleVersion { Id = 44, Name = "Titan ES", ModelId = 25 },
            new MotorcycleVersion { Id = 45, Name = "Titan ESD", ModelId = 25 },
            new MotorcycleVersion { Id = 46, Name = "Titan EX", ModelId = 25 },
            new MotorcycleVersion { Id = 47, Name = "Sport", ModelId = 25 },
            new MotorcycleVersion { Id = 48, Name = "Job", ModelId = 25 },
            new MotorcycleVersion { Id = 49, Name = "Fan ESI", ModelId = 25 },
            new MotorcycleVersion { Id = 50, Name = "Fan ESDI", ModelId = 25 },
            new MotorcycleVersion { Id = 51, Name = "Cargo", ModelId = 25 },
            new MotorcycleVersion { Id = 52, Name = "Titan Mix KS", ModelId = 25 },
            new MotorcycleVersion { Id = 53, Name = "Titan Mix ES", ModelId = 25 },
            new MotorcycleVersion { Id = 54, Name = "Titan Mix ESD", ModelId = 25 },
            new MotorcycleVersion { Id = 55, Name = "Start", ModelId = 25 },

            new MotorcycleVersion { Id = 56, Name = "KS", ModelId = 26 },
            new MotorcycleVersion { Id = 57, Name = "ES", ModelId = 26 },
            new MotorcycleVersion { Id = 58, Name = "EX", ModelId = 26 },

            new MotorcycleVersion { Id = 59, ModelId = 27 },
            
            new MotorcycleVersion { Id = 60, ModelId = 28 },

            new MotorcycleVersion { Id = 61, ModelId = 29 },

            new MotorcycleVersion { Id = 62, ModelId = 30 },

            new MotorcycleVersion { Id = 63, ModelId = 31 },

            new MotorcycleVersion { Id = 64, ModelId = 32 },

            new MotorcycleVersion { Id = 65, ModelId = 33 },

            new MotorcycleVersion { Id = 66, ModelId = 34 },
            new MotorcycleVersion { Id = 67, Name = "Avant", ModelId = 34 },

            new MotorcycleVersion { Id = 68, ModelId = 35 },
            new MotorcycleVersion { Id = 69, Name = "Super", ModelId = 35 },
            new MotorcycleVersion { Id = 70, Alias = "DTN 180", ModelId = 35 },
            new MotorcycleVersion { Id = 71, Alias = "DTZ 180", ModelId = 35 },

            new MotorcycleVersion { Id = 72, ModelId = 36 },
            new MotorcycleVersion { Id = 73, Alias = "RDZ 125 II", ModelId = 36 },

            new MotorcycleVersion { Id = 74, ModelId = 37 },
            new MotorcycleVersion { Id = 75, Alias = "MX 180L" ModelId = 37 },

            new MotorcycleVersion { Id = 76, ModelId = 38 },
        );
    }
}
