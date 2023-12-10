using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Dtos.Responses;
using Core.DataAccess.Paging;
using Business.Dtos.Requests;
using Core.Utilities.Results;

namespace Business.Abstracts;

public interface ICategoryService
{
    Task<IPaginate<GetListCategoryResponse>> GetListAsync();
    Task<CreatedCategoryResponse> Update(Category category);
    Task<IResult> Delete(Category category);
    Task<CreatedCategoryResponse> GetAsync(Guid Id);
    Task<CreatedCategoryResponse> Add(CreateCategoryRequest createCategoryRequest);
}
