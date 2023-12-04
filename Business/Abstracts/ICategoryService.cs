using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.Paging;

namespace Business.Abstracts;

public interface ICategoryService
{
    // public IList<Category> GetAll();
    Task<IPaginate<Category>> GetListAsync();
    Task Add(Category category);
}
