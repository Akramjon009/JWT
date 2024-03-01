using System.ComponentModel.DataAnnotations;

namespace EmailSenderApp.Domain.Entites.Models.StudentModels
{
    public class StudentModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int grade { get; set; }
        public string Login { get; set; }
        [MinLength(8)]
        public required string password { get; set; }
    }
}
