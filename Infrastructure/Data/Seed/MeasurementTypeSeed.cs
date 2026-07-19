public static class MeasurementTypeSeed {
    public static async Task SeedAsync(AppDbContext context)
    {
        if (!context.MeasurementType.Any())
        {
            context.MeasurementType.AddRange(
                new MeasurementType { Type = "absolute" },
                new MeasurementType { Type = "oversize" }
            );

            await context.SaveChangesAsync();
        }
    }

}