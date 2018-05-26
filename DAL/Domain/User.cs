using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Domain
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime RegistrationDate { get; set; }
        public int  IdProfile { get; set; }
        public virtual Profile Profile { get; set; }
    }
}
