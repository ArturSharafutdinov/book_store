using AutoMapper;
using book_store.Identity;
using book_store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace book_store
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
         

            CreateMap<UserSignUpResource, User>()
    .ForMember(u => u.UserName, opt => opt.MapFrom(ur => ur.Email));
        }
    }
}
