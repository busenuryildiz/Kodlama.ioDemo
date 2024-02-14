using Business.Dtos.Requests;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Business.Dtos.Responses.Users;
using Business.Dtos.Requests.Users;

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
