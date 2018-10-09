using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using MovieStore.DTOS;
using MovieStore.Models;

namespace MovieStore.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<CustomerModel, CustomerDTO>();
            Mapper.CreateMap<CustomerDTO, CustomerModel>();
        }
    }
}