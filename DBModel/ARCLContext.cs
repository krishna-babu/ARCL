namespace ARCL.DBModel
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ARCLContext : DbContext
    {
        public ARCLContext()
            : base("name=Db")
        {
        }

        public virtual DbSet<Season> Seasons { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual void SetModified(object entity)
        {
            Entry(entity).State = System.Data.Entity.EntityState.Modified;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Team>()
                .Property(e => e.BannerMessage)
                .IsUnicode(false);
        }
    }
}
