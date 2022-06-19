using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ABC.Api.Entities.RoomEN
{
    [Table("RoomPriceHistories")]
    public class RoomPriceHistory:BaseEntitiy
    {
        public decimal RoomPriceOld { get; set; }

        [StringLength(26)]
        public string RoomId { get; set; }

        public virtual Room Room { get; set; }
    }
}
