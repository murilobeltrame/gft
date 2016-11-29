using System;
using System.Collections.Generic;

namespace grades.Models
{
    public partial class ResponsavelGrade
    {
        public int IdResponsavel { get; set; }
        public int IdGrade { get; set; }
        public bool FlAtivo { get; set; }
        public bool FlDefault { get; set; }
        public DateTime DtAlt { get; set; }

        public virtual Grade IdGradeNavigation { get; set; }
        public virtual Responsavel IdResponsavelNavigation { get; set; }
    }
}
