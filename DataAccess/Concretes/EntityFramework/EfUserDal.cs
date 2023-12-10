using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfUserDal : EfRepositoryBase<User, Guid, CourseAcademyContext>, IUserDal
    {
        CourseAcademyContext _context;

        public EfUserDal(CourseAcademyContext context) : base(context)
        {
            _context = context;
        }
    }

}
