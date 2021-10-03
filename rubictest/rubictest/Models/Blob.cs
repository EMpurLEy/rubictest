using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rubictest.Models
{
    public class Blob
    {
        public int Id { get; set; }
        public byte [] Content { get; set; }
        public string Extention { get; set; }
    }
}
