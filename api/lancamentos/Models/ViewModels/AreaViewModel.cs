using System;
using System.Collections.Generic;

namespace lancamentos.Models
{
    public partial class AreaViewModel
    {
        public int IdArea { get; set; }
        public string CodSapArea { get; set; }
        public string NmArea { get; set; }

        public virtual EmpresaViewModel Empresa { get; set; }
    }
}