using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.Repositories;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfCourseDal : EfRepositoryBase<Course, int, NorthwindContext>, ICourseDal
    {
        public EfCourseDal(NorthwindContext context) : base(context)
        {
        }
    }
}
