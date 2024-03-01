using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace EmailSenderApp.Domain.Entites.Models.EmailModels
{
    public class EmailModel
    {
        public long id { get; set; }
        [EmailAddress]
        public string email { get; set; }
        public string password { get; set; }
        public string Fullname { get; set; }

    }
}
