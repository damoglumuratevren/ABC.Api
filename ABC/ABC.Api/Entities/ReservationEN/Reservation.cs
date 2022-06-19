using ABC.Api.Entities.CustomerEN;
using ABC.Api.Entities.RoomEN;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ABC.Api.Entities.ReservationEN
{
    [Table("Reservations")]
    public class Reservation : BaseEntitiy
    {
        public DateTime ReservationDtm { get; set; }
        [StringLength(26)]
        public string CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
        [StringLength(26)]
        public string RoomId{ get; set; }

        public virtual Room Room { get; set; }

        public bool IsReservationComplate { get; set; } = false;

        public decimal MyProperty { get; set; }
    }
}
