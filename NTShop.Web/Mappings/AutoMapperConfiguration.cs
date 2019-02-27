using AutoMapper;
using NTShop.Model.Models;
using NTShop.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NTShop.Web.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.CreateMap<Post, PostViewModel>();
            Mapper.CreateMap<PostCategory, PostCategoryViewModel>();
            Mapper.CreateMap<Tag, TagViewModel>();
        }
    }
}