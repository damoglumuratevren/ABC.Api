using System.ComponentModel.DataAnnotations;

namespace ABC.Api.Entities
{
    public class BaseEntitiy
    {
        [Key]
        [StringLength(26)]
        public string Id { get; set; }

        public bool IsActive { get; set; } = true;

        [StringLength(26)]
        public string CreatedId { get; set; }

        public DateTime CreatedDtm { get; set; }

        [StringLength(26)]
        public string? UpdatedId { get; set; }

        public DateTime? UpdatedDtm { get; set; }

    }
}
