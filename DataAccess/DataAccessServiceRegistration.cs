using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using DataAccess.Concretes.EntityFramework;
using DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public static class DataAccessServiceRegistration
    {
        public static IServiceCollection AddDataAccessServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<CourseAcademyContext>(options => options.UseSqlServer(configuration.GetConnectionString("Kodlama.ioDemo")));
            services.AddScoped<ICourseDal, EfCourseDal>();
            services.AddScoped<ICategoryDal, EfCategoryDal>();
            services.AddScoped<IUserDal, EfUserDal>();
            services.AddScoped<IInstructorDal, EfInstructorDal>();
            return services;
        }
    }
}
