using Core.DataAccess;
using Core.DataAccess.Paging;
using Core.DataAccess.Repositories;
using Entities.Concretes;
using Entities.DTO;

namespace DataAccess.Abstracts;

public interface ICourseDal : IRepository<Course, int>, IAsyncRepository<Course, int>
{
    Task<IPaginate<CourseDetailDto>> GetCourseDetails();
}
