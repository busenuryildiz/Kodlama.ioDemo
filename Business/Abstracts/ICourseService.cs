using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Core.Utilities.Results;

namespace Business.Abstracts
{
    public interface ICourseService
    {
        Task<IPaginate<GetListCourseResponse>> GetListAsync();
        Task<CreatedCourseResponse> Update(Course course);
        Task<IResult> Delete(Course course);
        Task<CreatedCourseResponse> GetAsync(Guid Id);
        Task<CreatedCourseResponse> Add(CreateCourseRequest createCourseRequest);

    }
}
