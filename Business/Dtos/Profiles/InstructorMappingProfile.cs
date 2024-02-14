using Entities.Concretes;
using AutoMapper;
using Core.DataAccess.Paging;
using Business.Dtos.Responses.Instructors;
using Business.Dtos.Requests.Instructors;

namespace Business.Dtos.Profiles
{
    public class InstructorMappingProfile : Profile
    {
        public InstructorMappingProfile()
        {
            CreateMap<CreateInstructorRequest, Instructor>().ReverseMap();
            CreateMap<Instructor, CreatedInstructorResponse>().ReverseMap();
            CreateMap<Instructor, GetListInstructorResponse>().ReverseMap();
            CreateMap<Paginate<Instructor>, Paginate<GetListInstructorResponse>>().ReverseMap();
        }
    }
}
