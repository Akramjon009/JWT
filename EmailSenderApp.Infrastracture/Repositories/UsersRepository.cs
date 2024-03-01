using EmailSenderApp.Application.Abstaraction.Repositories;
using EmailSenderApp.Domain.Entites.Models.AuthModels;
using Microsoft.EntityFrameworkCore;

namespace EmailSenderApp.Infrastracture.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(ApplicationDbContext context, DbSet<User> dbSet) : base(context, dbSet)
        {
        }
    }
}
