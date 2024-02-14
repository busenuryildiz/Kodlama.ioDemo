using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Business.Abstracts;
using Business.Constants;
using Business.Dtos.Requests;
using Business.Dtos.Requests.Users;
using Business.Dtos.Responses.Users;
using Core.DataAccess.Paging;
using Core.Utilities.Results;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        IMapper _mapper;

        public UserManager(IUserDal userDal, IMapper mapper)
        {
            _userDal = userDal;
            _mapper = mapper;
        }
        public async Task<CreatedUserResponse> Add(CreateUserRequest createUserRequest)
        {
            User user = _mapper.Map<User>(createUserRequest);
            User createdUser = await _userDal.AddAsync(user);
            CreatedUserResponse createdUserResponse = _mapper.Map<CreatedUserResponse>(createdUser);
            return createdUserResponse;
        }

        public async Task<IPaginate<GetListUserResponse>> GetListAsync()
        {
            var userList = await _userDal.GetListAsync();
            var mappedList = _mapper.Map<Paginate<GetListUserResponse>>(userList);
            return mappedList;
        }

        public async Task<CreatedUserResponse> Update(User user)
        {
            var updatedUser = await _userDal.UpdateAsync(user);
            var mappedUser = _mapper.Map<CreatedUserResponse>(updatedUser);
            return mappedUser;
        }

        public async Task<IResult> Delete(User user)
        {
            await _userDal.DeleteAsync(user, true);
            return new SuccessResult(Messages.UserDeleted);
        }

        public async Task<CreatedUserResponse> GetAsync(Guid id)
        {
            var getUser = await _userDal.GetAsync(g => g.Id == id);
            var mappedUser = _mapper.Map<CreatedUserResponse>(getUser);
            return mappedUser;
        }
    }
}
