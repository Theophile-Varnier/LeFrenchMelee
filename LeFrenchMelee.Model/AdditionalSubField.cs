using LeFrenchMelee.Model.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeFrenchMelee.Model
{
    [Table("SubField")]
    public class AdditionalSubField
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Tournament")]
        public int TournamentId { get; set; }

        public virtual Tournament Tournament { get; set; }

        public string Key { get; set; }

        public FormFieldType Type { get; set; }
    }
}
