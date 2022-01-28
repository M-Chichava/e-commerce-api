using System.Threading.Tasks.Sources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Application.Dtos;
using Domain;
using Microsoft.Extensions.Configuration;

namespace Application.Helpers
{
    public class ProductUrlResolver : IValueResolver<Product, ProductDto, string>
    {
         private readonly IConfiguration _config;
        public ProductUrlResolver(IConfiguration config)     
    {
        _config = config;
    }
        public string Resolve(Product source, ProductDto destination, string destMember, ResolutionContext context)
        {
            if (!string.IsNullOrEmpty(source.PictureUrl))
            {
                return _config["ApiUrl"] + source.PictureUrl;
            }
            return null;
        }
    }
}