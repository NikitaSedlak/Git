using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Domain
{
    public class Flight
    {
        public int ID { get; set; }
        public int IdAircraft { get; set; }
        public virtual Aircraft Aircraft { get; set; }
        public DateTime ArrivalTime { get; set; }
        public DateTime DepartureTime { get; set; }
        public int IdArrivalCity { get; set; }
        public int IdDepartureCity { get; set; }

        [ForeignKey("ArrivalCity")]
        public virtual City ArrivalCity { get; set; }

        [ForeignKey("DepartureCity")]
        public virtual City DepartureCity { get; set; }
    }
}
