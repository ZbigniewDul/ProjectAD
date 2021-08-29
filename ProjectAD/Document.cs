using System;
using System.ComponentModel;

namespace ProjectAD
{
    public class Document
    {
        [DisplayName("Id")]
        public int Id { get; set; }

        [DisplayName("Nr Uchwały")]
        public string Name { get; set; }

        [DisplayName("Termin wykonania")]
        public DateTime CreatedDate { get; set; }
        public string DocType { get; set; }
        public string DocPath { get; set; }

        [DisplayName("Przedmiot uchwały")]
        public string Description { get; set; }
        public string DocFileName { get; set; }

        [DisplayName("Odpowiedzialny za wykonanie uchwały")]
        public string PersonWhoHasBeenResponsible { get; set; }
    }
}
