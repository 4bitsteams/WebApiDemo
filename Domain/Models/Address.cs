using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public  class Address : BaseEntity
    {
        public string? StreetAdress
        {
            get;
            set;
        }
        public string? City
        {
            get;
            set;
        }
        public string? State
        {
            get;
            set;
        }
        public string? ZipCode
        {
            get;
            set;
        }
    }
}
