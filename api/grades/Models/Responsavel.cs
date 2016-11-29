using System;
using System.Collections.Generic;

namespace grades.Models
{
    public partial class Responsavel
    {
        public Responsavel()
        {
            ResponsavelGrade = new HashSet<ResponsavelGrade>();
        }

        public int IdResponsavel { get; set; }
        public string CsResponsavel { get; set; }
        public string NmResponsavel { get; set; }
        public string EmailResponsavel { get; set; }
        public string RamalResponsavel { get; set; }
        public bool FlInativo { get; set; }
        public DateTime? DtAlt { get; set; }
        public bool? FlRelatorio { get; set; }
        public bool? FlAprovador { get; set; }
        public bool FlAprovadorExcedente { get; set; }

        public virtual ICollection<ResponsavelGrade> ResponsavelGrade { get; set; }
    }
}
