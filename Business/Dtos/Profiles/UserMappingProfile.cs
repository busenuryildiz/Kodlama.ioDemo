using Business.Dtos.Requests;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Business.Dtos.Responses;
using Core.DataAccess.Paging;

namespace Business.Dtos.Profiles
{
    public class UserMappingProfile : Profile
    {
        public UserMappingProfile()
        {
            CreateMap<CreateUserRequest, User>().ReverseMap();
            CreateMap<User, CreatedUserResponse>().ReverseMap();
            CreateMap<User, GetListUserResponse>().ReverseMap();
            CreateMap<Paginate<User>, Paginate<GetListUserResponse>>().ReverseMap();
        }
    }
}
