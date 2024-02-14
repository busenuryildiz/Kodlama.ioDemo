using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.Paging;
using Core.Utilities.Results;
using Business.Dtos.Responses.Categories;
using Business.Dtos.Requests.Categories;

namespace Business.Abstracts;

public interface ICategoryService
{
    Task<IPaginate<GetListCategoryResponse>> GetListAsync();
    Task<CreatedCategoryResponse> Update(Category category);
    Task<IResult> Delete(Category category);
    Task<CreatedCategoryResponse> GetAsync(int Id);
    Task<CreatedCategoryResponse> Add(CreateCategoryRequest createCategoryRequest);
}
