namespace BuyTicket {
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BuyTicketContext : DbContext {
        public BuyTicketContext()
            : base("name=BuyTicket") {
        }

        public virtual DbSet<Film> Films { get; set; }
        public virtual DbSet<Hall> Halls { get; set; }
        public virtual DbSet<Sean> Seans { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }
        public virtual DbSet<Type> Types { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.Entity<Film>()
                .HasMany(e => e.Seans)
                .WithRequired(e => e.Film)
                .HasForeignKey(e => e.Film_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Hall>()
                .HasMany(e => e.Seans)
                .WithRequired(e => e.Hall)
                .HasForeignKey(e => e.Hall_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sean>()
                .HasMany(e => e.Tickets)
                .WithRequired(e => e.Sean)
                .HasForeignKey(e => e.Seans_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Type>()
                .HasMany(e => e.Seans)
                .WithRequired(e => e.Type)
                .HasForeignKey(e => e.Type_Id)
                .WillCascadeOnDelete(false);
        }
    }
}
