using System.ComponentModel.DataAnnotations.Schema;

namespace LeFrenchMelee.Model
{
    [Table("News")]
    public class News : Entity
    {
        public string Content { get; set; }

        public string Title { get; set; }
    }
}
