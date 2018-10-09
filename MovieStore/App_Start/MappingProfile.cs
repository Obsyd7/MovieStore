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
            //Domain to Dto
            Mapper.CreateMap<CustomerModel, CustomerDTO>();
            Mapper.CreateMap<MovieModel, MovieDto>();


            //Dto to Domain
            Mapper.CreateMap<CustomerDTO, CustomerModel>();
            Mapper.CreateMap<MovieDto, MovieModel>();
        }
    }
}