using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAD
{
    public class Document
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public string DocType { get; set; }
        public string DocPath { get; set; }
        public string Description { get; set; }
        public string DocFileName { get; set; }
    }
}
