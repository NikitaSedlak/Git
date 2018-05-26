using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations.Schema;


namespace DAL.Domain
{
    class OrderedTicket
    {
        public int Id { get; set; }
        public int IdTicket { get; set; }
        public int IdOrder { get; set; }
        public virtual Ticket Ticket { get; set; }
        public virtual Order Order { get; set; }

    }
}
