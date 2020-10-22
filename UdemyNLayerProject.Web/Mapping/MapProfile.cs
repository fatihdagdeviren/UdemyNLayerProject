﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UdemyNLayerProject.Web.DTOs;
using UdemyNLayerProject.Core.Models;

namespace UdemyNLayerProject.Web.Mapping
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<Category, CategoryDTO>();
            CreateMap<CategoryDTO, Category>();
            
            CreateMap<CategoryWithProductDTO, Category>();
            CreateMap<Category, CategoryWithProductDTO>();
           
            CreateMap<ProductDTO, Product>();
            CreateMap<Product, ProductDTO>();

            CreateMap<ProductWithCategoryDTO, Product>();
            CreateMap<Product, ProductWithCategoryDTO>();
        }
    }
}
