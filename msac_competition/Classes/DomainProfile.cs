﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using msac_competition.BLL.DTO;
using msac_competition.Models;

namespace msac_competition.Classes
{
    public class DomainProfile : Profile
    {
        public DomainProfile()
        {
           // CreateMap<TeamDTO, TeamViewModel>();
            CreateMap<CompetitionDTO, CompetitionViewModel>()
                //.ForMember(dto => dto.Teams, opt => opt.MapFrom(x => x.Teams.Select(y => y.Competitions).ToList()));
                .ForMember(dto => dto.Name, opt => opt.MapFrom(x => x.Name))
                .ForMember(dto => dto.Teams, opt => opt.MapFrom(x => x.Teams));

            CreateMap<TeamDTO, TeamViewModel>()
                //.ForMember(dto => dto.Teams, opt => opt.MapFrom(x => x.Teams.Select(y => y.Competitions).ToList()));
                .ForMember(dto => dto.Name, opt => opt.MapFrom(x => x.Name))
                .ForMember(dto => dto.Competitions, opt => opt.MapFrom(x => x.Competitions));
        }
    }
}