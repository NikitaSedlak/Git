using DAL.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Context : DbContext
    {
        public Context()
            : base("conectionString")
        {

        }

        //static Context()
        //{
        //    Database.SetInitializer<Context>(new ContextInitializer());
        //}

        public virtual DbSet<Aircraft> Aircrafts {get; set;}
        public virtual DbSet<City> Cities {get; set;}
        public virtual DbSet<ComfortLevel> ComfortLevels {get; set;}
        public virtual DbSet<Flight> Flights {get; set;}
        public virtual DbSet<Order> Orders {get; set;}
        public virtual DbSet<OrderedTicket> OrderedTickets {get; set;}
        public virtual DbSet<Profile> Profiles {get; set;}
        public virtual DbSet<User> Users {get; set;}
        public virtual DbSet<Ticket> Tickets {get; set;}

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }
    }
}
