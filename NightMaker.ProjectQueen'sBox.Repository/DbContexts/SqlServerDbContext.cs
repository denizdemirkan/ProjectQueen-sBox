using Microsoft.EntityFrameworkCore;
using NightMaker.ProjectQueen_sBox.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NightMaker.ProjectQueen_sBox.Repository.DbContexts
{
    public class SqlServerDbContext : DbContext
    {
        public DbSet<Beehive> Beehives { get; set; }
        public DbSet<BeehiveDetail> BeehiveDetails { get; set; }
        public DbSet<BeehiveMaintenanceStatus> BeehiveMaintenanceStatuses { get; set; }
        public DbSet<BeehiveNote> BeehiveNotes { get; set; }
        public DbSet<Colony> Colonies { get; set; }
        public DbSet<ColonyDetail> ColonyDetails { get; set; }
        public DbSet<ColonyMaintenanceStatus> ColonyMaintenanceStatuses { get; set; }
        public DbSet<ColonyNote> ColonyNotes { get; set; }
        public DbSet<ColonyStock> ColonyStocks { get; set; }
        public DbSet<Queen> Queens { get; set; }
        public DbSet<Harvest> Harvests { get; set; }
        public DbSet<ProducerStock> ProducerStocks { get; set; }


        public SqlServerDbContext(DbContextOptions<SqlServerDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Search "Configurations" in the current Assembly (application)
           // modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
}
