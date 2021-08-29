using System.ComponentModel;

namespace ProjectAD
{
    public class DocumentBasicInfo
    {
        public string DocType { get; set; }
        [DisplayName("Id")]
        public int Id { get; set; }
        public string DocPath { get; set; }
        public string DocFileName { get; set; }
    }
}
