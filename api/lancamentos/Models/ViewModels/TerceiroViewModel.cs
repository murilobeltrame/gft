using System;
using System.Collections.Generic;

namespace lancamentos.Models
{
    public partial class TerceiroViewModel
    {
        public int IdTerceiro { get; set; }
        public string TrTerceiro { get; set; }
        public string NmTerceiro { get; set; }
        public string EmailTerceiro { get; set; }

        public virtual ConsultoriaViewModel Consultoria { get; set; }
    }
}
