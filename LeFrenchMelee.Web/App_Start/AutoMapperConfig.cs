using AutoMapper;
using LeFrenchMelee.Model;
using LeFrenchMelee.Web.Models;

namespace LeFrenchMelee.Web
{
    public class AutoMapperConfig
    {
        private static IMapper mapper;

        public static IMapper Mapper
        {
            get
            {
                return mapper;
            }
        }

        public static void RegisterMapping()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TournamentViewModel, Tournament>()
                .ForMember(obj => obj.Id, opt => opt.Ignore());
                cfg.CreateMap<Tournament, TournamentViewModel>()
                .ForMember(vm => vm.IdTournament, obj => obj.MapFrom(t => t.Id));
            }
            );
            mapper = config.CreateMapper();
        }
    }
}