using System;
using AutoMapper;
using MyWebAppApis.Models;
using MyWebAppApis.Models.DTOs;

namespace MyWebAppApis.Profiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile() 
        {
            CreateMap<Product, ProductReadDTO>();
        }
    }
}

