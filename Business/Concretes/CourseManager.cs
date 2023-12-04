using Business.Abstracts;
using Core.DataAccess.Paging;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstracts;

namespace Business.Concretes
{
    public class CourseManager : ICourseService

    {
        ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public async Task Add(Course course)
        {
            await _courseDal.AddAsync(course);

        }

        //public IList<Course> GetAll()
        //{
        //    //iş kodları
        //    EfCourseDal courseDal = new EfCourseDal();
        //    return courseDal.GetList();
        //}

        public async Task<IPaginate<Course>> GetListAsync()
        {
            return await _courseDal.GetListAsync();
        }
    }
}
