using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ABC.Api.Entities.PersonelEN
{
    [Table("Personels")]
    public class Personel : BaseEntitiy
    {


        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string  LastName { get; set; }

        [Required]
        [StringLength(100)]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(100)]
        public string Password { get; set; }


        [Required]
        [StringLength(10)]
        public string PhoneNumber { get; set; }

        public bool IsPartTime { get; set; }

        public decimal Price { get; set; }

        public bool IsBlocked { get; set; }

        public DateTime StartDateOfWork { get; set; }

        public DateTime? EndDateOfWork { get; set; }

        public string PersonelTypeId { get; set; }

        public virtual PersonelType PersonelType { get; set; }
    }
}
