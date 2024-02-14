using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Core.DataAccess.Paging;
using Business.Dtos.Requests.Courses;
using Business.Dtos.Responses.Courses;

namespace Business.Dtos.Profiles
{
    public class CourseMappingProfile : Profile
    {
        public CourseMappingProfile()
        {
            CreateMap<CreateCourseRequest, Course>().ReverseMap();
            CreateMap<Course, CreatedCourseResponse>().ReverseMap();
            CreateMap<Course, GetListCourseResponse>().ReverseMap();
            CreateMap<Paginate<Course>, Paginate<GetListCourseResponse>>().ReverseMap();
        }
    }
}
