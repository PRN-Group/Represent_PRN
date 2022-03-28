using FilmX.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FilmX.Data
{
    public class ApplicationContext : IdentityDbContext<User,UserRole,int>
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options):base(options)
        {

        }

        public DbSet<CostTicket> costTickets { get; set; }
        public DbSet<Film> films { get; set; }
        public DbSet<FilmCategory> filmCategories { get; set; }
        public DbSet<Room> rooms { get; set; }
        public DbSet<Seat> seats { get; set; }
        public DbSet<ShowTime> showTimes { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<UserRole> roles { get; set; }

        public DbSet<Order> orders { get; set; }
        public DbSet<OrderDetails> orderDetails { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            DataSeeding.Seeding(modelBuilder);

        }
    }
}
