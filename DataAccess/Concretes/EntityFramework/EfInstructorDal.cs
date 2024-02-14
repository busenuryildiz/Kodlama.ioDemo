using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfInstructorDal : EfRepositoryBase<Instructor, Guid, CourseAcademyContext>, IInstructorDal
    {
        CourseAcademyContext _context;

        public EfInstructorDal(CourseAcademyContext context) : base(context)
        {
            _context = context;
        }
    }

}
