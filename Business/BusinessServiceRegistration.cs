using DataAccess.Abstracts;
using DataAccess.Concretes;
using DataAccess.Contexts;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstracts;
using Business.Concretes;
using System.Reflection;

namespace Business
{

    public static class BusinessServiceRegistration
    {
        public static IServiceCollection AddBusinessServices(this IServiceCollection services)
        {
            services.AddScoped<ICourseService, CourseManager>();
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<IUserService, UserManager>();
            services.AddScoped<IInstructorService, InstructorManager>();
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }
    }

}
