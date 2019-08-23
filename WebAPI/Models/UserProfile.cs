using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class UserProfile :Profile
    {
        public UserProfile()
        {
            CreateMap<UserDetail, UserDetailModel>()
                .ReverseMap();
            CreateMap<ApplicationUser, ApplicationUserModel>()
                .ReverseMap();

        }
    }
}
