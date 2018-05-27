using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Domain
{
    public class Aircraft
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CompanyName { get; set; }
        public virtual ICollection<Flight> Flights { get; set; }

        public Aircraft()
        {
            Flights = new List<Flight>();
        }
    }
}
