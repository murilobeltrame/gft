using System;

namespace GFT.API.Lancamentos.Models
{
    public class Lancamento
    {
        public Prestador Prestador { get; set; }
        public Requisicao Requisicao{get;set;}
        public Unidade Unidade { get; set; }
        public string CentroCusto { get; set; }
        public DateTime Data { get; set; }
        public TimeSpan Periodo {get; set; }
        public StatusLancamento Status {get;set;}
    }
}