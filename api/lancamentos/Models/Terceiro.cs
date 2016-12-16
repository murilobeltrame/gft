using System;
using System.Collections.Generic;

namespace lancamentos.Models
{
    public partial class Terceiro
    {
        public Terceiro()
        {
            Apontamento = new HashSet<Apontamento>();
        }

        public int IdTerceiro { get; set; }
        public int IdConsultoria { get; set; }
        public string TrTerceiro { get; set; }
        public string NmTerceiro { get; set; }
        public string ContratoTerceiro { get; set; }
        public string EmailTerceiro { get; set; }
        public string CodPerfilTerceiro { get; set; }
        public bool FlFootprints { get; set; }
        public bool FlForponto { get; set; }
        public bool FlInativo { get; set; }
        public DateTime? DtAlt { get; set; }
        public byte[] ImAnexoTerceiro { get; set; }
        public string NmAnexoTerceiro { get; set; }
        public string TpAnexoTerceiro { get; set; }
        public int? IdTerceiroGestorResponsavel { get; set; }

        public virtual ICollection<Apontamento> Apontamento { get; set; }
        public virtual Consultoria IdConsultoriaNavigation { get; set; }
    }
}
