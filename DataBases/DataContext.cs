using DataBases.DataBaseClasses;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBases
{
    public class DataContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        public DataContext() : base("dbConn")
        {
            Database.SetInitializer<DataContext>(null);
        }
        public DbSet<tbl_Post> Post { get; set; }
    }
}
