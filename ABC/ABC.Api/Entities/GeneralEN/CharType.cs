using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ABC.Api.Entities.GeneralEN
{
    [Table("CharTypes")]
    public class CharType
    {
        [Key]
        [Required]
        [StringLength(20)]
        public string CharTypeCode { get; set; }

        [Required]
        [StringLength(200)]
        public string CharTypeText { get; set; }
       
        public bool IsActive { get; set; } = true;

        [StringLength(26)]
        public string CreatedId { get; set; }

        public DateTime CreatedDtm { get; set; }
    }
}
