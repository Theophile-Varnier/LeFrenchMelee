using Newtonsoft.Json;
using System;

namespace LeFrenchMelee.Web.Models
{
    [JsonObject]
    public abstract class AbstractViewModel
    {
        [JsonProperty]
        public int Id { get; set; }

        public DateTime CreationDate { get; set; }
    }
}