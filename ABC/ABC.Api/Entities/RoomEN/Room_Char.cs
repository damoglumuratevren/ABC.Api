using ABC.Api.Entities.GeneralEN;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ABC.Api.Entities.RoomEN
{
    [Table("Room_Chars")]
    public class Room_Char : BaseEntitiy
    {
        [Required]
        [StringLength(250)]
        public string Val { get; set; }

        public string CharTypeId { get; set; }

        public virtual CharType CharType { get; set; }

        public string RoomId { get; set; }

        public virtual Room Room { get; set; }

        //public virtual List<CharType> MyProperty { get; set; }
    }
}
