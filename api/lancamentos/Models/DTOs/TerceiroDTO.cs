using System;
using System.Collections.Generic;

namespace lancamentos.Models
{
    public partial class TerceiroDTO
    {
        public int IdTerceiro { get; set; }
        public string TrTerceiro { get; set; }
        public string NmTerceiro { get; set; }
        public string EmailTerceiro { get; set; }

        public virtual ConsultoriaDTO Consultoria { get; set; }
    }
}
