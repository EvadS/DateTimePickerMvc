using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DateTimePickerMvc.Models
{
    public class PersonContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }

        public PersonContext()
            : base()
        {
            var cs = ConfigurationManager.ConnectionStrings["ConnName"]
                                         .ConnectionString;

            this.Database.Connection.ConnectionString = cs;
        }
    }
}