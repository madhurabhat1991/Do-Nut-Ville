using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assgn3_Bhat_Madhura.Models
{
    public class EmailModel
    {
        public String EmailAddress { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String StreetAddress { get; set; }
        public int PostalCode { get; set; }
        public String City { get; set; }
        public String State { get; set; }
        public Boolean Sample { get; set; }
    }
}
