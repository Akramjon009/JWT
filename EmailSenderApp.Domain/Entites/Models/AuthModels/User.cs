using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace EmailSenderApp.Domain.Entites.Models.AuthModels
{
    public class User
    {
        public Guid Id {get; set;} = Guid.NewGuid();
        public string Name { get; set; }
        public string Login {  get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
