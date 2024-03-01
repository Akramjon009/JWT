using EmailSenderApp.Application.Abstaraction.IBaseRepositories;
using EmailSenderApp.Domain.Entites.Models.EmailModels;

namespace EmailSenderApp.Application.Abstaraction.Repositories
{
    public interface IUserRepository : IBaseRepository<EmailModel>
    {
    }
}
