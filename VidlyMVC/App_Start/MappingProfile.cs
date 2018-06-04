﻿using AutoMapper;
using VidlyMVC.Dtos;
using VidlyMVC.Models;

namespace VidlyMVC.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer, CustomerDto>();
            CreateMap<CustomerDto, Customer>().ForMember(c => c.Id, opt => opt.Ignore());

            CreateMap<Movie, MovieDto>();
            CreateMap<MovieDto, Movie>().ForMember(m => m.Id, opt => opt.Ignore());

            CreateMap<MembershipType, MembershipTypeDto>();
        }
    }
}