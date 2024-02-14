using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.Paging;
using Core.DataAccess.Repositories;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfCourseDal : EfRepositoryBase<Course, int, CourseAcademyContext>, ICourseDal
    {
        CourseAcademyContext _context;

        public EfCourseDal(CourseAcademyContext context) : base(context)
        {
            _context = context;
        }
    }
}

