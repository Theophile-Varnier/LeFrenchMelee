using LeFrenchMelee.Model;
using LeFrenchMelee.Services;
using LeFrenchMelee.Web.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace LeFrenchMelee.Web.Controllers.Api
{
    public class TournamentController : ApiController
    {
        private readonly ServiceProvider serviceProvider = new ServiceProvider();
        // GET api/values
        public IEnumerable<TournamentViewModel> Get()
        {
            return serviceProvider.TournamentService.GetAll().Select(AutoMapperConfig.Mapper.Map<TournamentViewModel>);
        }

        // GET api/values/5
        public TournamentViewModel Get(int id)
        {
            return AutoMapperConfig.Mapper.Map<TournamentViewModel>(serviceProvider.TournamentService.GetById(id));
        }

        // POST api/values
        public TournamentViewModel Post([FromBody]TournamentViewModel value)
        {
            Tournament tournament = serviceProvider.TournamentService.Insert(AutoMapperConfig.Mapper.Map<Tournament>(value));

            return AutoMapperConfig.Mapper.Map<TournamentViewModel>(tournament);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
