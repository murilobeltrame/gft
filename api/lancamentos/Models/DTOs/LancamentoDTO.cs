using System;
using System.Collections.Generic;

namespace lancamentos.Models
{
    public partial class LancamentoDTO
    {
        public int IdLancamento { get; set; }
        public string NrRequisicao { get; set; }
        public DateTime? DtLancamento { get; set; }
        public string NrProjetoLancamento { get; set; }
        public string DsLancamento { get; set; }
        public int? HoraLancamento { get; set; }
        public int? MinutoLancamento { get; set; }
        public int? IdGrade { get; set; }

        public virtual ApontamentoDTO Apontamento { get; set; }
        public virtual AreaDTO Area { get; set; }
        public virtual TipoLancamentoDTO Tipo { get; set; }
    }
}