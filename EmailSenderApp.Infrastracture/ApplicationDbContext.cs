using EmailSenderApp.Domain.Entites.Models.EmailModels;
using EmailSenderApp.Domain.Entites.Models.StudentModels;
using EmailSenderApp.Domain.Entites.Models.TeacherModels;
using Microsoft.EntityFrameworkCore;

namespace EmailSenderApp.Infrastracture
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) 
        {
            Database.Migrate();
        }
      
        public DbSet<TeacherModel> teacherModels {  get; set; }
        public DbSet<StudentModel> studentModels { get; set; }
        public DbSet<EmailModel> emailModels { get; set; }
    }
}
