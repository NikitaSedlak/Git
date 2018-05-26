using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations.Schema;


namespace DAL.Domain
{
    public class Ticket
    {
        public int Id { get; set; }
        public int ComfortLevelId { get; set; }
        public decimal Price { get; set; }
        public virtual Flight Flight { get; set; }
        public virtual ComfortLevel ComfortLevel { get; set; }

        [Index("Ticket_Flight_Seat", 1, IsUnique = true)]
        public int SeatNumber { get; set; }

        [Index("Ticket_Flight_Seat", 2, IsUnique = true)]
        public int FligthId { get; set; }

    }
}
