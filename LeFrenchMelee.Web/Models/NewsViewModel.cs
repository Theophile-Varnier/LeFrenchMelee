using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace LeFrenchMelee.Web.Models
{
    public class NewsViewModel : AbstractViewModel
    {
        [Required]
        [JsonProperty]
        [Display(Name = "")]
        public string Content { get; set; }

        [Required]
        [JsonProperty]
        [Display(Name = "Titre")]
        public string Title { get; set; }
    }
}