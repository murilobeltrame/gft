using System;
using System.Collections.Generic;

namespace lancamentos.Models
{
    public partial class Apontamento
    {
        public Apontamento()
        {
            Lancamento = new HashSet<Lancamento>();
        }

        public int IdApontamento { get; set; }
        public string MesAnoApontamento { get; set; }
        public int IdStatusApontamento { get; set; }
        public int IdTerceiro { get; set; }
        public decimal VlTotalApontamento { get; set; }
        public decimal? HorasTotalApontamento { get; set; }
        public decimal? VlDespesaApontamento { get; set; }
        public byte[] AnexoDespesaApontamento { get; set; }
        public string NmAnexoDespesaApontamento { get; set; }
        public string TpAnexoDespesaApontamento { get; set; }
        public string ObsDespesaApontamento { get; set; }
        public DateTime? DtAlt { get; set; }

        public virtual ICollection<Lancamento> Lancamento { get; set; }
        public virtual Terceiro IdTerceiroNavigation { get; set; }
    }
}
