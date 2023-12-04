﻿using Business.Abstracts;
using Core.DataAccess.Paging;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstracts;

namespace Business.Concretes;

public class CategoryManager : ICategoryService
{
    ICategoryDal _categoryDal;

    public CategoryManager(ICategoryDal categoryDal)
    {
        _categoryDal = categoryDal;
    }

    public async Task Add(Category category)
    {
        await _categoryDal.AddAsync(category);

    }

    //public IList<Category> GetAll()
    //{
    //    //iş kodları
    //    EfCategoryDal categoryDal = new EfCategoryDal();
    //    return categoryDal.GetList();
    //}

    public async Task<IPaginate<Category>> GetListAsync()
    {
        return await _categoryDal.GetListAsync();

    }
}