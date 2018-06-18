using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Domain
{
    public class Profile
    {
        [Key]
        [ForeignKey("User")]
        public int Id { get; set; }

        public string Surname { get; set; }
        public string Name { get; set; }
        public bool Access { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }

        public User User { get; set; }

        public virtual ICollection<Order> Order { get; set; }

        //public User User1
        //{
        //    get => default(User);
        //    set
        //    {
        //    }
        //}

        public Profile()
        {
            Order = new List<Order>();
        }
    }
}
