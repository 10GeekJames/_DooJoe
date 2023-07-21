namespace DojoSurveysInfrastructure;
public static class StartupSetup

{
    public static void AddDojoSurveysDbContext(this IServiceCollection services, string connectionString) =>

        services.AddDbContext<DojoSurveysDbContext>(options =>
            options.UseSqlite(connectionString, b => b.MigrationsAssembly("DojoSurveysApplication.Data")));

    public static void AddDojoSurveysInMemoryDbContext(this IServiceCollection services, string dbName) =>

        services.AddDbContext<DojoSurveysDbContext>(options =>
            options.UseInMemoryDatabase(dbName));
}

