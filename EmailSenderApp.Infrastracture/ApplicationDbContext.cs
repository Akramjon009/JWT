using EmailSenderApp.Domain.Entites.Models.AuthModels;
using EmailSenderApp.Domain.Entites.Models.EmailModels;
using EmailSenderApp.Domain.Entites.Models.StudentModels;
using EmailSenderApp.Domain.Entites.Models.TeacherModels;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace EmailSenderApp.Infrastracture
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) 
        {
            Database.Migrate();
        }
      
        DbSet<TeacherModel> teacherModels {  get; set; }
        DbSet<StudentModel> studentModels { get; set; }
        DbSet<EmailModel> emailModels { get; set; }
    }
}
