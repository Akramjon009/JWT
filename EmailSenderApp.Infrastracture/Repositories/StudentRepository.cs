using EmailSenderApp.Application.Abstaraction.Repositories;
using EmailSenderApp.Domain.Entites.Models.StudentModels;

namespace EmailSenderApp.Infrastracture.Repositories
{
    public class StudentRepository:BaseRepository<StudentModel>,IStudentRepository
    {
        public StudentRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
