using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneMusic.EntityLayer.Entities
{
    public class Message
    {
        public int MessageId { get; set; }
        public string Name { get; set; }
        public int Email { get; set; }
        public int Subject{ get; set; }
        public int Content { get; set; }
    }
}
