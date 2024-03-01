using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailSenderApp.Domain.Entites.Models.TeacherModels
{
    public class TeacherModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string subject { get; set; }
    }
}
