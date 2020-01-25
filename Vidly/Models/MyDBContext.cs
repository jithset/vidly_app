namespace Vidly.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MyDBContext : DbContext
    {
        public DbSet<Customer> Customers { get; set;}
        public DbSet<MembershipType> MembershipTypes { get; set; }
        public MyDBContext()
            : base("name=MyDBContext")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
