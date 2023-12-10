using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;

namespace Business.Abstracts
{
    public interface IUserService
    {
        Task<CreatedUserResponse> Add(CreateUserRequest createUserRequest);
        Task<CreatedUserResponse> Update(User user);
        Task<IResult> Delete(User user);
        Task<CreatedUserResponse> GetAsync(Guid Id);
        Task<IPaginate<GetListUserResponse>> GetListAsync();

    }
}
