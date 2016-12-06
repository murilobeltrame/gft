using System;
using System.Collections.Generic;

namespace lancamentos.Models
{
    public partial class Consultoria
    {
        public Consultoria()
        {
            Terceiro = new HashSet<Terceiro>();
        }

        public int IdConsultoria { get; set; }
        public string NmConsultoria { get; set; }
        public string CdConsultoria { get; set; }
        public DateTime? DtAlt { get; set; }

        public virtual ICollection<Terceiro> Terceiro { get; set; }
    }
}
