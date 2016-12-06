using System;
using System.Collections.Generic;

namespace lancamentos.Models
{
    public partial class TipoLancamentoDTO
    {
        public int IdTipoLancamento { get; set; }
        public string NmTipoLancamento { get; set; }
        public string DsTipoLancamento { get; set; }
    }
}