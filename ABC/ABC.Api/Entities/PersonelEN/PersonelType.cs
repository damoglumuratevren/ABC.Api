using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ABC.Api.Entities.PersonelEN
{
    [Table("PersonelTypes")]
    public class PersonelType:BaseEntitiy
    {
        [Required]
        [StringLength(100)]
        public string Text { get; set; }

        public virtual List<Personel> Personels { get; set; }
    }
}
