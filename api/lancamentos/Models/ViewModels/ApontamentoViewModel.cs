using System;
using System.Collections.Generic;

namespace lancamentos.Models
{
    public partial class ApontamentoViewModel
    {
        public int IdApontamento { get; set; }
        public string MesAnoApontamento { get; set; }
        public int IdTerceiro { get; set; }
        public decimal? VlDespesaApontamento { get; set; }

        public virtual TerceiroViewModel Terceiro { get; set; }
    }
}