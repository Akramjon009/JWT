using System.ComponentModel.DataAnnotations;


namespace EmailSenderApp.Domain.Entites.Models.EmailModels
{
    public class EmailModel
    {
        public long id { get; set; }
        [EmailAddress]
        public string email { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}
