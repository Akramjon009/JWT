using System.ComponentModel.DataAnnotations;


namespace EmailSenderApp.Domain.Entites.Models.EmailModels
{
    public class EmailDTO
    {
        [EmailAddress]
        public string Email { get; set; }
    }
}
