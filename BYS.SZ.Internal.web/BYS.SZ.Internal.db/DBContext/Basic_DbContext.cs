using BYS.SZ.Internal.db.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYS.SZ.Internal.db.DBContext
{
    public class Basic_DbContext : DbContext
    {
        public Basic_DbContext() : base("BYDataConn")
        {
            Database.SetInitializer<Basic_DbContext>(new Basic_DbContextInitializer());
        }
        public DbSet<Employee_Basic> Employee_Basic { get; set; }
        public DbSet<Employee_Cost> Employee_Cost { get; set; }
        public DbSet<BillingInfo> BillingInfo { get; set; }
        public DbSet<MSTitle> MSTitle { get; set; }
        public DbSet<SOW> SOW { get; set; }
        public class Basic_DbContextInitializer : CreateDatabaseIfNotExists<Basic_DbContext>
        {
            protected override void Seed(Basic_DbContext context)
            {
                context.Employee_Basic.AddRange(new List<Employee_Basic>
                {
                    new Employee_Basic { UserName ="Pengmeng Wu", UserAlias = "v-pengwu", BeyondSoftID = 00029522, UserRole = "System Manager", Email = "wupengmeng@beyondsoft.com"},
                    new Employee_Basic { UserName ="Yuling Jiao", UserAlias = "v-yuljia", BeyondSoftID = 00032836, UserRole = "System Manager", Email = "jiaoyuling@beyondsoft.com"}
                });
                base.Seed(context);
            }
        }
    }
}
