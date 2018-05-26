using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Domain
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public bool IsPaid { get; set; }
        public int IdProfile { get; set; }
        public virtual Profile Profile { get; set; }
    }
}
