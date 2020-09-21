using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace AmericaSecond
{
    public class ContextFactory : IDesignTimeDbContextFactory<FirstAndSecondContext>
    {
        public ContextFactory()
        { 
        }

        private IConfiguration Configuration => new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();

        public FirstAndSecondContext CreateDbContext(string[] args)
        {

            var builder = new DbContextOptionsBuilder<FirstAndSecondContext>();
            builder.UseSqlServer(Configuration.GetConnectionString("FirstAndSecond"));

            return new FirstAndSecondContext(builder.Options);
        }
    }
}
