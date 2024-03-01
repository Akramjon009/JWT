using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailSenderApp.Domain.Entites.Models.TeacherModels
{
    public class TeacherDTO
    {
        public required string FullName { get; set; } 
        public required string Login {  get; set; }
        
        [MinLength(8)]
        public required string password { get; set; }
        public required string subject { get; set; }
    }
}
