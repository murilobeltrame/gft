using System;
using System.Collections.Generic;

namespace lancamentos.Models
{
    public partial class ApontamentoDTO
    {
        public int IdApontamento { get; set; }
        public string MesAnoApontamento { get; set; }
        public int IdTerceiro { get; set; }
        public decimal? VlDespesaApontamento { get; set; }

        public virtual TerceiroDTO Terceiro { get; set; }
    }
}