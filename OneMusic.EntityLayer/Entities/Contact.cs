using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OneMusic.EntityLayer.Entities
{
    public class Contact
    {
        public int ContactId { get; set; }

        public string  Address { get; set; }
        public string  Email { get; set; }
        public string  phones { get; set; }
        public string  MapUrl { get; set; }
    }
}
