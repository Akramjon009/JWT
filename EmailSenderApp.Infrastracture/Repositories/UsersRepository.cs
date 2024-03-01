using EmailSenderApp.Application.Abstaraction.Repositories;
using EmailSenderApp.Domain.Entites.Models.AuthModels;
using EmailSenderApp.Domain.Entites.Models.EmailModels;
using Microsoft.EntityFrameworkCore;

namespace EmailSenderApp.Infrastracture.Repositories
{
    public class UserRepository : BaseRepository<EmailModel>, IUserRepository
    {
        public UserRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
