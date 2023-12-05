using Core.DataAccess.Paging;
using Entities.Concretes;
using Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ICourseService
    {
        // public IList<Course> GetAll();
        Task<IPaginate<Course>> GetListAsync();
        Task Add(Course course);
        Task<IPaginate<CourseDetailDto>> GetDetailsListAsync();

    }
}
