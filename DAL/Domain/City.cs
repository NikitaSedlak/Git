using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Domain
{
    public class City
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int PostIndex { get; set; }

        [InverseProperty("ArrivalCity")]
        public virtual ICollection<Flight> ArrivalFlights { get; set; }

        [InverseProperty("DepartureCity")]
        public virtual ICollection<Flight> DepartureFlights { get; set; }

    }
}
