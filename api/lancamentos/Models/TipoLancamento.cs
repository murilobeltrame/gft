using System;
using System.Collections.Generic;

namespace lancamentos.Models
{
    public partial class TipoLancamento
    {
        public TipoLancamento()
        {
            Lancamento = new HashSet<Lancamento>();
        }

        public int IdTipoLancamento { get; set; }
        public string NmTipoLancamento { get; set; }
        public string DsTipoLancamento { get; set; }
        public DateTime? DtAlt { get; set; }

        public virtual ICollection<Lancamento> Lancamento { get; set; }
    }
}
