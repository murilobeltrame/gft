using System;
using System.Collections.Generic;

namespace grades.Models
{
    public partial class Grade
    {
        public Grade()
        {
            ResponsavelGrade = new HashSet<ResponsavelGrade>();
        }

        public int IdGrade { get; set; }
        public string NmGrade { get; set; }
        public string SgGrade { get; set; }
        public bool FlInativo { get; set; }
        public bool? FlCriapedidoauto { get; set; }

        public virtual ICollection<ResponsavelGrade> ResponsavelGrade { get; set; }
    }
}
