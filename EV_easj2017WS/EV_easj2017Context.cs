namespace EV_easj2017WS
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EV_easj2017Context : DbContext
    {
        public EV_easj2017Context()
            : base("name=EV_easj2017Context")
        {
            base.Configuration.ProxyCreationEnabled = false;
        }

        public virtual DbSet<Events> Events { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Events>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Events>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Events>()
                .Property(e => e.Place)
                .IsUnicode(false);
        }
    }
}
