using System;
using System.Collections.Generic;

namespace lancamentos.Models
{
    public partial class Empresa
    {
        public Empresa()
        {
            Area = new HashSet<Area>();
        }

        public int IdEmpresa { get; set; }
        public string NmEmpresa { get; set; }
        public string CdSap { get; set; }
        public DateTime? DtAlt { get; set; }
        public string Cnpj { get; set; }
        public bool FlInativo { get; set; }
        public int? IdAmbienteSap { get; set; }

        public virtual ICollection<Area> Area { get; set; }
    }
}
