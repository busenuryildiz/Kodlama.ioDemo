using Business.Dtos.Requests;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Core.DataAccess.Paging;
using Business.Dtos.Responses.Users;
using Business.Dtos.Requests.Users;

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
