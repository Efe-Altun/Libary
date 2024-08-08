using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Libary.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class LibaryDbContextFactory : IDesignTimeDbContextFactory<LibaryDbContext>
{
    public LibaryDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();
        
        LibaryEfCoreEntityExtensionMappings.Configure();

        var builder = new DbContextOptionsBuilder<LibaryDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));
        
        return new LibaryDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Libary.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
