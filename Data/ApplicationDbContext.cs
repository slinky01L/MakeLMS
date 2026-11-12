using MakeLMS.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MakeLMS.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Module> Modules { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<LessonResource> LessonResources { get; set; }
        public DbSet<Quiz> Quizes { get; set; }
        public DbSet<Reading> Readings { get; set; }
        public DbSet<Video> Videos { get; set; }
    }
}
