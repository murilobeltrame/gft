using System;
using System.Collections.Generic;

namespace lancamentos.Models
{
    public partial class Area
    {
        public Area()
        {
            Lancamento = new HashSet<Lancamento>();
        }

        public int IdArea { get; set; }
        public int IdEmpresa { get; set; }
        public string CodSapArea { get; set; }
        public string NmArea { get; set; }
        public string CnpjArea { get; set; }
        public bool FlFaturarEmpresa { get; set; }
        public DateTime? DtAlt { get; set; }
        public bool FlCriapedidoauto { get; set; }

        public virtual ICollection<Lancamento> Lancamento { get; set; }
        public virtual Empresa IdEmpresaNavigation { get; set; }
    }
}
