namespace GFT.API.Lancamentos.Models
{
    public class Requisicao
    {
        public int Numero { get; set; }
        public string Descricao { get; set; }
        public TipoRequisicao Tipo { get; set; }
    }
}