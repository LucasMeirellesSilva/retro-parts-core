public static class MotorcycleModelSeed
{
    public static async Task SeedAsync(AppDbContext context)
    {
        if (await context.MotorcycleModel.AnyAsync())
            return;

        var hondaId = await context.MotorcycleBrand
            .Where(x => x.Name == "Honda")
            .Select(x => x.Id)
            .SingleAsync();

        context.MotorcycleModel.AddRange(
            new MotorcycleModel { Name = "CG 125", BrandId = hondaId },      // 1976
            new MotorcycleModel { Name = "ML 125", BrandId = hondaId },      // 1977
            new MotorcycleModel { Name = "Turuna 125", BrandId = hondaId },  // 1979
            new MotorcycleModel { Name = "CB 400", BrandId = hondaId },      // 1980
            new MotorcycleModel { Name = "XL 250", BrandId = hondaId },      // 1982
            new MotorcycleModel { Name = "CB 450", BrandId = hondaId },      // 1983
            new MotorcycleModel { Name = "XL 125", BrandId = hondaId },      // 1984
            new MotorcycleModel { Name = "XLX 250", BrandId = hondaId },     // 1984
            new MotorcycleModel { Name = "XLX 350", BrandId = hondaId },     // 1987
            new MotorcycleModel { Name = "Today 125", BrandId = hondaId },   // 1989
            new MotorcycleModel { Name = "NX 150", BrandId = hondaId },      // 1989
            new MotorcycleModel { Name = "CBX 150", BrandId = hondaId },     // 1990
            new MotorcycleModel { Name = "NX 350", BrandId = hondaId },      // 1990
            new MotorcycleModel { Name = "C100", BrandId = hondaId },        // 1992 (Dream) 1998 (Biz)
            new MotorcycleModel { Name = "NX 200", BrandId = hondaId },      // 1993
            new MotorcycleModel { Name = "CBX 200", BrandId = hondaId },     // 1993
            new MotorcycleModel { Name = "XR 200", BrandId = hondaId },      // 1993
            new MotorcycleModel { Name = "XLR 125", BrandId = hondaId },     // 1996
            new MotorcycleModel { Name = "CB 500", BrandId = hondaId },      // 1997
            new MotorcycleModel { Name = "NX 400", BrandId = hondaId },      // 1999
            new MotorcycleModel { Name = "CBX 250", BrandId = hondaId },     // 2001
            new MotorcycleModel { Name = "XR 250", BrandId = hondaId },      // 2001
            new MotorcycleModel { Name = "NXR 125", BrandId = hondaId },     // 2003
            new MotorcycleModel { Name = "NXR 150", BrandId = hondaId },     // 2003
            new MotorcycleModel { Name = "CG 150", BrandId = hondaId },      // 2004
            new MotorcycleModel { Name = "Biz 125", BrandId = hondaId },     // 2005
            new MotorcycleModel { Name = "Pop 100", BrandId = hondaId },     // 2007
            new MotorcycleModel { Name = "Biz 100", BrandId = hondaId },     // 2012
        );

        await context.SaveChangesAsync();
    }
}