using System.ComponentModel.DataAnnotations;


namespace EmailSenderApp.Domain.Entites.Models.EmailModels
{
    public class EmailDTO
    {
        [EmailAddress]
        public required string Email { get; set; }
        [MinLength(8)]
        public required string password { get; set; }
        public required string Fullname { get; set; }
    }
}
