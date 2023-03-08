using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Person : BaseEntity
    {
        public string? Name
        {
            get;
            set;
        }
        public int Age
        {
            get;
            set;
        }
        public Address? Address
        {
            get;
            set;
        }
        public List<Email>? Emails
        {
            get;
            set;
        }
    }
}
