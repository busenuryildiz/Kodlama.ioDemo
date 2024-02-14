using Business.Abstracts;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Business.Constants;
using DataAccess.Abstracts;
using Core.Utilities.Results;
using Business.Dtos.Requests.Categories;
using Business.Dtos.Responses.Categories;

namespace Business.Concretes;

public class CategoryManager : ICategoryService
{
    ICategoryDal _categoryDal;
    IMapper _mapper;


    public CategoryManager(ICategoryDal categoryDal, IMapper mapper)
    {
        _categoryDal = categoryDal;
        _mapper = mapper;

    }

    public async Task<IPaginate<GetListCategoryResponse>> GetListAsync()
    {
        var categoryList = await _categoryDal.GetListAsync();
        var mappedList = _mapper.Map<Paginate<GetListCategoryResponse>>(categoryList);
        return mappedList;
    }
    public async Task<CreatedCategoryResponse> Add(CreateCategoryRequest createCategoryRequest)
    {
        Category category = _mapper.Map<Category>(createCategoryRequest);
        Category createdCategory = await _categoryDal.AddAsync(category);
        CreatedCategoryResponse createdCategoryResponse = _mapper.Map<CreatedCategoryResponse>(createdCategory);
        return createdCategoryResponse;
    }

    public async Task<CreatedCategoryResponse> Update(Category category)
    {
        var updatedCategory = await _categoryDal.UpdateAsync(category);
        var mappedCategory = _mapper.Map<CreatedCategoryResponse>(updatedCategory);
        return mappedCategory;
    }

    public async Task<IResult> Delete(Category category)
    {
        await _categoryDal.DeleteAsync(category, true);
        return new SuccessResult(Messages.CategoryDeleted);
    }

    public async Task<CreatedCategoryResponse> GetAsync(int id)
    {
        var getCategory = await _categoryDal.GetAsync(g => g.Id == id);
        var mappedCategory = _mapper.Map<CreatedCategoryResponse>(getCategory);
        return mappedCategory;
    }
}
