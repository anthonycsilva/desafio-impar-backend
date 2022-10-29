using ImparApi.Business.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImparApi.Infra.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Photo> Photos { get; set; }

        private readonly string ConnectionStringLocal = "Server=localhost;Database=MasterLocal;User Id=sa;Password=Mandrak707";
        private readonly string ConnectionStringAzure = "Server=sql-anthonyeldy.database.windows.net;Database=ImparApi;User Id=adm;Password=kVV0Hak4lU8FHKgCqE4w9hZ4je039e5B;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionStringLocal);
        }
    }
}
