namespace PingPongPlayersAPI.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PingPongPlayerDbModel : DbContext
    {
        public PingPongPlayerDbModel()
            : base("name=PingPongPlayerDbModel")
        {
        }

        public virtual DbSet<Player> Players { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Player>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Player>()
                .Property(e => e.SkillLevel)
                .IsUnicode(false);

            modelBuilder.Entity<Player>()
                .Property(e => e.Email)
                .IsUnicode(false);
        }
    }
}
