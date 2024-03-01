using EmailSenderApp.Application.Abstaraction.Repositories;
using EmailSenderApp.Domain.Entites.Models.TeacherModels;

namespace EmailSenderApp.Infrastracture.Repositories
{
    public class TheacherRepository:BaseRepository<TeacherModel>,ITeacherRepository
    {
        public TheacherRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
