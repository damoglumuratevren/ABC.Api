using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ABC.Api.Entities.PersonelEN
{
    [Table("PersonelPriceHistories")]
    public class PersonelPriceHistory : BaseEntitiy
    {
        public decimal OldPrice { get; set; }

        [StringLength(26)]
        public string PersonelId { get; set; }

        public virtual Personel Personel { get; set; }
    }
}
