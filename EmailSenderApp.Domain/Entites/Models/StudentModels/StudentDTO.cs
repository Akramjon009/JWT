using System.ComponentModel.DataAnnotations;


namespace EmailSenderApp.Domain.Entites.Models.StudentModels
{
    public class StudentDTO
    {
        
        public required string FullName { get; set; }
        public required int grade { get; set; }
        public required string Login { get; set; }
        [MinLength(8)]
        public required string password { get; set; }
    }
}
