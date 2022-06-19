using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ABC.Api.Entities.CustomerEN
{
    [Table("Customers")]
    public class Customer : BaseEntitiy
    {
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }


        [Required]
        [StringLength(11)]
        public string TCKN { get; set; }


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
    }
}
