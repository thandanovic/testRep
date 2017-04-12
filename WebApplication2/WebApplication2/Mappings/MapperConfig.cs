using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using WebApplication2.Models;

namespace WebApplication2.Mappings
{
    public class MapperConfig
    {
        public static void InitMapper()
        {
            try
            {
                Mapper.Initialize(a =>
                {
                    a.CreateMap<Blog, BlogViewModel>();
                });
                Mapper.AssertConfigurationIsValid();
            }
            catch 
            {

            }
        }
    }
}