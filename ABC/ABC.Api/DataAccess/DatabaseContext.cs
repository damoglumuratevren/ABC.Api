using ABC.Api.Entities.CustomerEN;
using ABC.Api.Entities.GeneralEN;
using ABC.Api.Entities.PersonelEN;
using ABC.Api.Entities.ReservationEN;
using ABC.Api.Entities.RoomEN;
using Microsoft.EntityFrameworkCore;

namespace ABC.Api.DataAccess
{
    public class DatabaseContext:DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CharType> CharTypes { get; set; }
        public DbSet<Personel> Personels { get; set; }
        public DbSet<PersonelPriceHistory> PersonelPriceHistories { get; set; }
        public DbSet<PersonelType> PersonelTypes { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Room_Char> Room_Chars { get; set; }
        public DbSet<RoomPriceHistory> RoomPriceHistories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseSqlServer("Server=MEVREN-DAMOGLU;Database=ABCHotel;Trusted_Connection=True;Connect Timeout=30;MultipleActiveResultSets=True;");
            }

        }

    }
}
