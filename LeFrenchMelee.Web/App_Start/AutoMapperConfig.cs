﻿using AutoMapper;
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
            var config = new MapperConfiguration(cfg => cfg.CreateMap<TournamentViewModel, Tournament>());
            mapper = config.CreateMapper();
        }
    }
}