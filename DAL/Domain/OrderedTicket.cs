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

        [Index(IsUnique = true)]
        public int IdTicket { get; set; }

        [Index(IsUnique = true)]
        public int IdOrder { get; set; }

        public virtual Ticket Ticket { get; set; }
        public virtual Order Order { get; set; }

    }
}
