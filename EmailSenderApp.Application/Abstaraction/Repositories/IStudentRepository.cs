using EmailSenderApp.Application.Abstaraction.IBaseRepositories;
using EmailSenderApp.Domain.Entites.Models.StudentModels;

namespace EmailSenderApp.Application.Abstaraction.Repositories
{
    public interface IStudentRepository : IBaseRepository<StudentModel>
    {
    }
}
