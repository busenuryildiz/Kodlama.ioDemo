using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.Repositories;
using DataAccess.Contexts;

namespace DataAccess.Concretes.EntityFramework;

public class EfCategoryDal : EfRepositoryBase<Category,int,CourseAcademyContext>,ICategoryDal
{
    private CourseAcademyContext _context;
    public EfCategoryDal(CourseAcademyContext context) : base(context)
    {
        _context = context;
    }
}
