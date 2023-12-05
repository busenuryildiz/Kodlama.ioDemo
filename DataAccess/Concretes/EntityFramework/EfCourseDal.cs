using Core.DataAccess.EntityFramework;
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
using Entities.DTO;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfCourseDal : EfRepositoryBase<Course, int, TobetoContext>, ICourseDal
    {
        TobetoContext _context;
        public EfCourseDal(TobetoContext context) : base(context)
        {
            _context = context;
        }
        //public List<CourseDetailDto> GetCourseDetails()
        //{
        //    var result = from co in Context.Courses
        //                 join ca in Context.Categories
        //                     on co.CategoryId equals ca.Id
        //                 select new CourseDetailDto
        //                 {
        //                     CourseName = co.Name,
        //                     CategoryName = ca.Name,
        //                     CourseDescription = co.Description,
        //                 };
        //    return result.ToList();
        //}

        public async Task<IPaginate<CourseDetailDto>> GetCourseDetails()
        {
            int index = 0;
            int size = 20;

            var result = await (from course in _context.Courses
                join category in _context.Categories
                    on course.CategoryId equals category.Id
                select new CourseDetailDto
                {
                    Id = course.Id,
                    CategoryName = category.Name,
                    CourseName = course.Name
                }).ToPaginateAsync(index, size, 0);

            return result;
        }
    }

}

