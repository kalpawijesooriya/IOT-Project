namespace IOTProject
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using IOTProject.Models;

    public partial class IOTMOdel : DbContext
    {
        public IOTMOdel()
            : base("name=IOTMOdel")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<Identify> Identifies { get; set; }
        public virtual DbSet<IP> IPs { get; set; }
        public virtual DbSet<Switch> Switches { get; set; }
    }
}
