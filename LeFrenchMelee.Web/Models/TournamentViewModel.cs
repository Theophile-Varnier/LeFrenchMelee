using LeFrenchMelee.Model.Enum;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LeFrenchMelee.Web.Models
{
    [JsonObject]
    public class TournamentViewModel : AbstractViewModel
    {
        [Required]
        [JsonProperty]
        [Display(Name="Nom du tournoi")]
        public string Name { get; set; }

        [Required]
        [JsonProperty]
        [Display(Name="Lieux")]
        public string Place { get; set; }

        [Required]
        [JsonProperty]
        [Display(Name="Date de début")]
        public DateTime StartDate { get; set; }

        [Required]
        [JsonProperty]
        [Display(Name="Date de fin")]
        public DateTime EndDate { get; set; }

        public Dictionary<string, FormFieldType> AdditionalFields { get; set; }
    }
}