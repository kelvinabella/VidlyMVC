using AutoMapper;
using VidlyMVC.Dtos;
using VidlyMVC.Models;

namespace VidlyMVC.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer, CustomerDto>();
            CreateMap<CustomerDto, Customer>();
        }
    }
}