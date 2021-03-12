using AutoMapper;
using Lotte_OpdrachtDeel2.Dto;
using Lotte_OpdrachtDeel2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lotte_OpdrachtDeel2.AutoMapper
{
    public class Automapper : Profile
    {
        public Automapper()
        {
            CreateMap<House, CreateHouseDTO>()
            .ReverseMap();
        }

    }
}
