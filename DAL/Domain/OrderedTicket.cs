using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations.Schema;


namespace DAL.Domain
{
    public class OrderedTicket
    {
        public int Id { get; set; }

        public int TicketId { get; set; }
        public virtual Ticket Ticket { get; set; }

        public int OrderId { get; set; }
        public virtual Order Order { get; set; }

    }
}
