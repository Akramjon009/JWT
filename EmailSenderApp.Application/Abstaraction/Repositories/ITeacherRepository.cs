using EmailSenderApp.Application.Abstaraction.IBaseRepositories;
using EmailSenderApp.Domain.Entites.Models.TeacherModels;

namespace EmailSenderApp.Application.Abstaraction.Repositories
{
    public interface ITeacherRepository: IBaseRepository<TeacherModel>
    {
    }
}
