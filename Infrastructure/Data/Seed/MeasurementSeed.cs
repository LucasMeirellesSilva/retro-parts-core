public static class MeasurementSeed 
{
    public static async Task SeedAsync(AppDbContext context) 
    {
        if (await context.Measurement.AnyAsync()) return;

        var absoluteId = await context.MeasurementType
            .Where(x => x.Type == "absolute")
            .Select(x => x.Id)
            .SingleAsync();

        var oversizeId = await context.MeasurementType
            .Where(x => x.Type == "oversize")
            .Select(x => x.Id)
            .SingleAsync();

        context.Measurement.AddRange(
            new Measurement { Size = 0.25, MeasurementTypeId = oversizeId },
            new Measurement { Size = 0.50, MeasurementTypeId = oversizeId },
            new Measurement { Size = 0.75, MeasurementTypeId = oversizeId },
            new Measurement { Size = 1.00, MeasurementTypeId = oversizeId },
            new Measurement { Size = 1.25, MeasurementTypeId = oversizeId },
            new Measurement { Size = 1.50, MeasurementTypeId = oversizeId },
            new Measurement { Size = 1.75, MeasurementTypeId = oversizeId },
            new Measurement { Size = 2.00, MeasurementTypeId = oversizeId },
        );

        await context.SaveChangesAsync();
    }
}