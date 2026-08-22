public static class MotorcycleVersionSeed
{
    public static async Task SeedAsync(AppDbContext context)
    {
        if (await context.MotorcycleVersion.AnyAsync())
            return;

        var cg125Id = await context.MotorcycleModel.Where(x => x.Name == "CG 125").Select(x => x.Id).SingleAsync();
        var ml125Id = await context.MotorcycleModel.Where(x => x.Name == "ML 125").Select(x => x.Id).SingleAsync();
        var turuna125Id = await context.MotorcycleModel.Where(x => x.Name == "Turuna 125").Select(x => x.Id).SingleAsync();
        var cb400Id = await context.MotorcycleModel.Where(x => x.Name == "CB 400").Select(x => x.Id).SingleAsync();
        var xl250Id = await context.MotorcycleModel.Where(x => x.Name == "XL 250").Select(x => x.Id).SingleAsync();
        var xl125Id = await context.MotorcycleModel.Where(x => x.Name == "XL 125").Select(x => x.Id).SingleAsync();
        var cb450Id = await context.MotorcycleModel.Where(x => x.Name == "CB 450").Select(x => x.Id).SingleAsync();
        var xlx250Id = await context.MotorcycleModel.Where(x => x.Name == "XLX 250").Select(x => x.Id).SingleAsync();
        var xlx350Id = await context.MotorcycleModel.Where(x => x.Name == "XLX 350").Select(x => x.Id).SingleAsync();
        var today125Id = await context.MotorcycleModel.Where(x => x.Name == "Today 125").Select(x => x.Id).SingleAsync();
        var nx150Id = await context.MotorcycleModel.Where(x => x.Name == "NX 150").Select(x => x.Id).SingleAsync();
        var cbx150Id = await context.MotorcycleModel.Where(x => x.Name == "CBX 150").Select(x => x.Id).SingleAsync();
        var nx350Id = await context.MotorcycleModel.Where(x => x.Name == "NX 350").Select(x => x.Id).SingleAsync();
        var c100Id = await context.MotorcycleModel.Where(x => x.Name == "C100").Select(x => x.Id).SingleAsync();
        var cbx200Id = await context.MotorcycleModel.Where(x => x.Name == "CBX 200").Select(x => x.Id).SingleAsync();
        var xr200Id = await context.MotorcycleModel.Where(x => x.Name == "XR 200").Select(x => x.Id).SingleAsync();
        var xlr125Id = await context.MotorcycleModel.Where(x => x.Name == "XLR 125").Select(x => x.Id).SingleAsync();
        var cb500Id = await context.MotorcycleModel.Where(x => x.Name == "CB 500").Select(x => x.Id).SingleAsync();
        var nx400Id = await context.MotorcycleModel.Where(x => x.Name == "NX 400").Select(x => x.Id).SingleAsync();
        var cbx250Id = await context.MotorcycleModel.Where(x => x.Name == "CBX 250").Select(x => x.Id).SingleAsync();
        var xr250Id = await context.MotorcycleModel.Where(x => x.Name == "XR 250").Select(x => x.Id).SingleAsync();
        var nxr125Id = await context.MotorcycleModel.Where(x => x.Name == "NXR 125").Select(x => x.Id).SingleAsync();
        var nxr150Id = await context.MotorcycleModel.Where(x => x.Name == "NXR 150").Select(x => x.Id).SingleAsync();
        var cg150Id = await context.MotorcycleModel.Where(x => x.Name == "CG 150").Select(x => x.Id).SingleAsync();
        var biz125Id = await context.MotorcycleModel.Where(x => x.Name == "Biz 125").Select(x => x.Id).SingleAsync();
        var biz100Id = await context.MotorcycleModel.Where(x => x.Name == "Biz 100").Select(x => x.Id).SingleAsync();
        var pop100Id = await context.MotorcycleModel.Where(x => x.Name == "Pop 100").Select(x => x.Id).SingleAsync();

        context.MotorcycleVersion.AddRange(

            // CG 125
            new MotorcycleVersion { Alias = "CG Bolinha", ModelId = cg125Id },
            new MotorcycleVersion { ModelId = cg125Id },
            new MotorcycleVersion { Name = "Cargo", ModelId = cg125Id },
            new MotorcycleVersion { Name = "Titan", ModelId = cg125Id },
            new MotorcycleVersion { Name = "Titan KS", ModelId = cg125Id },
            new MotorcycleVersion { Name = "Titan KSE", ModelId = cg125Id },
            new MotorcycleVersion { Name = "Titan ES", ModelId = cg125Id },
            new MotorcycleVersion { Name = "Fan", ModelId = cg125Id },
            new MotorcycleVersion { Name = "Fan KS", ModelId = cg125Id },
            new MotorcycleVersion { Name = "Fan ES", ModelId = cg125Id },
            new MotorcycleVersion { Name = "Fan ESD", ModelId = cg125Id },

            // ML 125
            new MotorcycleVersion { ModelId = ml125Id },

            // Turuna 125
            new MotorcycleVersion { ModelId = turuna125Id },

            // CB 400
            new MotorcycleVersion { ModelId = cb400Id },
            new MotorcycleVersion { Name = "II", ModelId = cb400Id },

            // XL 250
            new MotorcycleVersion { Alias = "XLR 250", ModelId = xl250Id },

            // CB 450
            new MotorcycleVersion { ModelId = cb450Id },
            new MotorcycleVersion { Name = "Custom", ModelId = cb450Id },
            new MotorcycleVersion { Name = "DX", ModelId = cb450Id },
            new MotorcycleVersion { Name = "Esporte", ModelId = cb450Id },
            new MotorcycleVersion { Name = "TR", ModelId = cb450Id },

            // XL 125
            new MotorcycleVersion { Alias = "XL 125S", ModelId = xl125Id },
            new MotorcycleVersion { Name = "Duty", ModelId = xl125Id },

            // XLX 250
            new MotorcycleVersion { ModelId = xlx250Id },

            // XLX 350
            new MotorcycleVersion { ModelId = xlx350Id },

            // Today 125
            new MotorcycleVersion { ModelId = today125Id },

            // NX 150
            new MotorcycleVersion { ModelId = nx150Id },

            // CBX 150
            new MotorcycleVersion { Alias = "Aero", ModelId = cbx150Id },

            // NX 350
            new MotorcycleVersion { Alias = "Sahara", ModelId = nx350Id },

            // C100
            new MotorcycleVersion { Name = "Dream", ModelId = c100Id },
            new MotorcycleVersion { Name = "Biz ES", ModelId = c100Id },
            new MotorcycleVersion { Name = "Biz+", ModelId = c100Id },

            // CBX 200
            new MotorcycleVersion { Alias = "Strada", ModelId = cbx200Id },

            // XR 200
            new MotorcycleVersion { Alias = "XR 200R", ModelId = xr200Id },

            // XLR 125
            new MotorcycleVersion { ModelId = xlr125Id },

            // CB 500
            new MotorcycleVersion { ModelId = cb500Id },

            // NX 400
            new MotorcycleVersion { Alias = "Falcon", ModelId = nx400Id },

            // CBX 250
            new MotorcycleVersion { Alias = "Twister", ModelId = cbx250Id },

            // XR 250
            new MotorcycleVersion { Alias = "Tornado", ModelId = xr250Id },

            // NXR 125
            new MotorcycleVersion { Alias = "Bros 125", ModelId = nxr125Id },

            // CG 150
            new MotorcycleVersion { Name = "Titan KS", ModelId = cg150Id },
            new MotorcycleVersion { Name = "Titan ES", ModelId = cg150Id },
            new MotorcycleVersion { Name = "Titan ESD", ModelId = cg150Id },
            new MotorcycleVersion { Name = "Titan EX", ModelId = cg150Id },
            new MotorcycleVersion { Name = "Sport", ModelId = cg150Id },
            new MotorcycleVersion { Name = "Job", ModelId = cg150Id },
            new MotorcycleVersion { Name = "Fan ESI", ModelId = cg150Id },
            new MotorcycleVersion { Name = "Fan ESDI", ModelId = cg150Id },
            new MotorcycleVersion { Name = "Cargo", ModelId = cg150Id },
            new MotorcycleVersion { Name = "Titan Mix KS", ModelId = cg150Id },
            new MotorcycleVersion { Name = "Titan Mix ES", ModelId = cg150Id },
            new MotorcycleVersion { Name = "Titan Mix ESD", ModelId = cg150Id },
            new MotorcycleVersion { Name = "Start", ModelId = cg150Id },

            // Biz 125
            new MotorcycleVersion { Name = "KS", ModelId = biz125Id },
            new MotorcycleVersion { Name = "ES", ModelId = biz125Id },
            new MotorcycleVersion { Name = "EX", ModelId = biz125Id },

            // Pop 100
            new MotorcycleVersion { ModelId = pop100Id }

            // NXR 150
            new MotorcycleVersion { Alias = "Bros 150", ModelId = nxr150Id },

            // Biz 100
            new MotorcycleVersion { ModelId = biz100Id }
        );

        await context.SaveChangesAsync();
    }
}