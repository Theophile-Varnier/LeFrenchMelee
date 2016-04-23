using AutoMapper;
using LeFrenchMelee.Model;
using LeFrenchMelee.Web.Models;
using System.Collections.Generic;

namespace LeFrenchMelee.Web.Helpers.ValueResolvers
{
    public class AdditionalFieldResolver : ValueResolver<TournamentViewModel, List<AdditionalSubField>>
    {
        protected override List<AdditionalSubField> ResolveCore(TournamentViewModel source)
        {
            List<AdditionalSubField> res = new List<AdditionalSubField>();
            foreach(var field in source.AdditionalFields)
            {
                res.Add(new AdditionalSubField
                {
                    TournamentId = source.Id,
                    Key = field.Key,
                    Type = field.Value
                });
            }
            return res;
        }
    }
}