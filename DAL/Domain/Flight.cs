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
        public int Id { get; set; }

        public int AircraftId { get; set; }
        public virtual Aircraft Aircraft { get; set; }

        public DateTime ArrivalTime { get; set; }
        public DateTime DepartureTime { get; set; }


        public int ArrivalCityId { get; set; }

        [ForeignKey("ArrivalCityId")]
        public virtual City ArrivalCity { get; set; }

        public int DepartureCityId { get; set; }

        [ForeignKey("DepartureCityId")]
        public virtual City DepartureCity { get; set; }

        public Aircraft Aircraft1
        {
            get => default(Aircraft);
            set
            {
            }
        }

        public City City
        {
            get => default(City);
            set
            {
            }
        }
    }
}
