using ABC.Api.Entities.Enums;
using ABC.Api.Entities.ReservationEN;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ABC.Api.Entities.RoomEN
{
    [Table("Rooms")]
    public class Room : BaseEntitiy
    {
        [Required]
        [StringLength(15)]
        public string RoomNumber { get; set; }

        public decimal RoomPrice { get; set; }

        public FloorType FloorType { get; set; }

        public virtual List<Reservation> Reservations { get; set; }

        public Room()
        {
            Reservations = new List<Reservation>();
        }
    }
}
