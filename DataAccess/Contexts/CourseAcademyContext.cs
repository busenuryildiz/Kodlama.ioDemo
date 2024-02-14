using Entities.Concretes;
using System.Reflection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;


namespace DataAccess.Contexts;

public class CourseAcademyContext : DbContext
{
    protected IConfiguration Configuration { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Instructor> Instructors { get; set; }
    public CourseAcademyContext(DbContextOptions dbContextOptions, IConfiguration configuration) : base(dbContextOptions)
    {
        Configuration = configuration;
        Database.EnsureCreated();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

}
