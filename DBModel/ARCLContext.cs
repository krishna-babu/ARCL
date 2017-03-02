namespace ARCL.DBModel
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ARCLContext : DbContext
    {
        public ARCLContext()
            : base("name=ARCLContext")
        {
        }

        public virtual DbSet<C__RefactorLog> C__RefactorLog { get; set; }
        public virtual DbSet<Match> Matches { get; set; }
        public virtual DbSet<Player> Players { get; set; }
        public virtual DbSet<Season> Seasons { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Score> Scores { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Match>()
                .Property(e => e.Venue)
                .IsFixedLength();

            modelBuilder.Entity<Team>()
                .Property(e => e.BannerMessage)
                .IsUnicode(false);

            modelBuilder.Entity<Team>()
                .HasMany(e => e.HostMatches)
                .WithRequired(e => e.Team1Team)
                .HasForeignKey(e => e.Team1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Team>()
                .HasMany(e => e.VistingMatches)
                .WithRequired(e => e.Team2Team)
                .HasForeignKey(e => e.Team2)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .Property(e => e.City)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.State)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .HasMany(e => e.Players)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Player>()
                .HasMany(e => e.RunsScored)
                .WithRequired(e => e.Striker)
                .HasForeignKey(e => e.Stricker_Id).WillCascadeOnDelete(false); 

            modelBuilder.Entity<Player>()
                .HasMany(e => e.Bowled)
                .WithRequired(e => e.Bowler)
                .HasForeignKey(e => e.Bowler_Id).WillCascadeOnDelete(false);

            modelBuilder.Entity<Player>()
                .HasMany(e => e.Fielded)
                .WithRequired(e => e.Fielder)
                .HasForeignKey(e => e.Fielder_Id).WillCascadeOnDelete(false);

            modelBuilder.Entity<Player>()
                .HasMany(e => e.NonStrikerBalls)
                .WithRequired(e => e.NonStriker)
                .HasForeignKey(e => e.NonStriker_Id).WillCascadeOnDelete(false);

            modelBuilder.Entity<Match>()
                .HasMany(e => e.ScoreByEveryBall)
                .WithRequired(e => e.Match)
                .HasForeignKey(e => e.Match_Id);

        }

        public virtual void SetModified(object entity)
        {
            Entry(entity).State = System.Data.Entity.EntityState.Modified;
        }
    }
}
