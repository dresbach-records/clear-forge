using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Clearforge.Infrastructure.Data
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ClearforgeDbContext>
    {
        public ClearforgeDbContext CreateDbContext(string[] args)
        {
            // Ajuste o caminho para apontar para o projeto da API onde o appsettings.json reside
            string apiProjectPath = Path.Combine(Directory.GetCurrentDirectory(), "..", "Clearforge.Api");

            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(apiProjectPath)
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<ClearforgeDbContext>();
            var connectionString = configuration.GetConnectionString("PostgresConnection");

            // Configura o DbContext para usar Npgsql (PostgreSQL).
            builder.UseNpgsql(connectionString);

            return new ClearforgeDbContext(builder.Options);
        }
    }
}
