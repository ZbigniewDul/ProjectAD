using System;
using System.ComponentModel;

namespace ProjectAD
{
    public class Document : DocumentBasicInfo
    {

        [DisplayName("Nr Uchwały")]
        public string Name { get; set; }

        [DisplayName("Termin wykonania")]
        public DateTime CreatedDate { get; set; }

        [DisplayName("Odpowiedzialny za wykonanie uchwały")]
        public string PersonWhoHasBeenResponsible { get; set; }

        [DisplayName("Przedmiot uchwały")]
        public string Description { get; set; }

    }
}
