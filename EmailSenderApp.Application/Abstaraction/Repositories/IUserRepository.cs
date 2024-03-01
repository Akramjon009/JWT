using EmailSenderApp.Application.Abstaraction.IBaseRepositories;
using EmailSenderApp.Domain.Entites.Models.AuthModels;

namespace EmailSenderApp.Application.Abstaraction.Repositories
{
    public interface IUserRepository : IBaseRepository<User>
    {
    }
}
