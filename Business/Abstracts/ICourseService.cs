using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Business.Dtos.Responses.Courses;
using Business.Dtos.Requests.Courses;

namespace Business.Abstracts
{
    public interface ICourseService
    {
        Task<IPaginate<GetListCourseResponse>> GetListAsync();
        Task<CreatedCourseResponse> Update(Course course);
        Task<IResult> Delete(Course course);
        Task<CreatedCourseResponse> GetAsync(int Id);
        Task<CreatedCourseResponse> Add(CreateCourseRequest createCourseRequest);

    }
}
