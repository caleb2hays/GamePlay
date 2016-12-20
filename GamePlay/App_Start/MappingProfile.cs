using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using GamePlay.Dtos;
using GamePlay.Models;

namespace GamePlay.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //Domain to Dto
            // <Source, Target>
            Mapper.CreateMap<CustomerModel, CustomerDto>();
            Mapper.CreateMap<GameModel, GameDto>();
            Mapper.CreateMap<MembershipTypeModel, MembershipTypeDto>();
            Mapper.CreateMap<CategoryModel, CategoryDto>();

            //Dto to Domain
            Mapper.CreateMap<CustomerDto, CustomerModel>()
                .ForMember(c => c.Id, opt => opt.Ignore());

            Mapper.CreateMap<GameDto, GameModel>()
                .ForMember(c => c.Id, opt => opt.Ignore());

        }
    }
}