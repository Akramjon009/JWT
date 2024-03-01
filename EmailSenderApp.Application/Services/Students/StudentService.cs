using EmailSenderApp.Application.Abstaraction.Repositories;
using EmailSenderApp.Domain.Entites.Models.AuthModels;
using EmailSenderApp.Domain.Entites.Models.EmailModels;
using System.Linq.Expressions;

namespace EmailSenderApp.Application.Services.Students
{
    public class StudentService
    {
        private readonly IUserRepository _userRepository;

        public StudentService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<EmailModel> Create(EmailDTO userDTO)
        {
            var user = new EmailModel()
            {
                email = userDTO.Email
            };
            var result = await _userRepository.Create(user);

            return result;
        }

        public async Task<bool> Delete(Expression<Func<User, bool>> expression)
        {
            var result = await _userRepository.Delete(expression);

            return result;
        }

        public async Task<IEnumerable<UserViewModel>> GetAll()
        {
            var users = await _userRepository.GetAll();

            var result = users.Select(model => new UserViewModel
            {
                Name = model.Name,
                Email = model.Email,
                Role = model.Role,
            });

            return result;
        }

        public async Task<User> GetByAny(Expression<Func<User, bool>> expression)
        {
            var result = await _userRepository.GetByAny(expression);

            return result;
        }

        public async Task<User> GetByEmail(string email)
        {
            var result = await _userRepository.GetByAny(x => x.Email == email);
            return result;
        }

        public async Task<User> GetById(int Id)
        {
            var result = await _userRepository.GetByAny(x => x.Id == Id);
            return result;
        }

        public async Task<User> GetByLogin(string login)
        {
            var reult = await _userRepository.GetByAny(y => y.Login == login);
            return reult;
        }

        public async Task<User> GetByName(string name)
        {
            var result = await _userRepository.GetByAny(d => d.Name == name);
            return result;
        }

        public async Task<User> Update(int Id, UserDTO userDTO)
        {
            var res = await _userRepository.GetByAny(x => x.Id == Id);

            if (res != null)
            {
                var user = new User()
                {
                    Name = userDTO.Name,
                    Email = userDTO.Email,
                    Login = userDTO.Login,
                    Password = userDTO.Password,
                    Role = userDTO.Role,
                };
                var result = await _userRepository.Update(user);

                return result;
            }
            return new User();

        }
    }
}
