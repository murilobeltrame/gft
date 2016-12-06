using System;
using System.Collections.Generic;

namespace lancamentos.Models
{
    public partial class Lancamento
    {
        public int IdLancamento { get; set; }
        public int IdApontamento { get; set; }
        public int? IdLancamentoFoot { get; set; }
        public string NrRequisicao { get; set; }
        public int IdTipoLancamento { get; set; }
        public int? IdArea { get; set; }
        public DateTime? DtLancamento { get; set; }
        public string NrProjetoLancamento { get; set; }
        public string DsLancamento { get; set; }
        public int? IdResponsavel { get; set; }
        public int? HoraLancamento { get; set; }
        public int? MinutoLancamento { get; set; }
        public int IdStatusLancamento { get; set; }
        public string ObsLancamento { get; set; }
        public DateTime? DtAlt { get; set; }
        public int? IdInformacaoNotaFiscal { get; set; }
        public int? IdGrade { get; set; }

        public virtual Apontamento IdApontamentoNavigation { get; set; }
        public virtual Area IdAreaNavigation { get; set; }
        public virtual TipoLancamento IdTipoLancamentoNavigation { get; set; }
    }
}
