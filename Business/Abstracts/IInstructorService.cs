using Business.Dtos.Requests.Instructors;
using Business.Dtos.Responses.Instructors;
using Core.DataAccess.Paging;
using Core.Utilities.Results;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IInstructorService
    {
        Task<IPaginate<GetListInstructorResponse>> GetListAsync();
        Task<CreatedInstructorResponse> Update(Instructor instructor);
        Task<IResult> Delete(Instructor instructor);
        Task<CreatedInstructorResponse> GetAsync(Guid Id);
        Task<CreatedInstructorResponse> Add(CreateInstructorRequest createInstructorRequest);
    }
}
