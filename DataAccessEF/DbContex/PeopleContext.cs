using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessEF.DbContex
{
    public class PeopleContext : DbContext
    {
        public PeopleContext(DbContextOptions options) : base(options) { }
        public DbSet<Person> Person
        {
            get;
            set;
        }
        public DbSet<Address> Address
        {
            get;
            set;
        }
        public DbSet<Email> Email
        {
            get;
            set;
        }
    }
}
