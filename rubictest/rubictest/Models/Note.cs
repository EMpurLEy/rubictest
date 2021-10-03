using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rubictest.Models
{
    public class Note
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime GreateTime { get; set; }
    }
}
