using System;
using System.Collections.Generic;
// using GFT.API.Lancamentos.Models;
using Microsoft.AspNetCore.Mvc;

namespace lancamentos.Controllers
{
    
    [Route("api/[controller]")]
    public class LancamentosController : Controller
    {
        // // GET api/lancamentos
        // [HttpGet]
        // public IEnumerable<Lancamento> Get()
        // {
        //     return new Lancamento[]{
        //         new Lancamento{
        //             Prestador = new Prestador{
        //                 Nome = "Murilo Beltrame Correia",
        //                 Consultoria = new Consultoria{
        //                     Nome = "Sismat"
        //                 }
        //             },
        //             Requisicao = new Requisicao{
        //                 Numero = 12345,
        //                 Descricao = "eComm",
        //                 Tipo = new TipoRequisicao {
        //                     Descricao = "Demandas TI Nova Versao"
        //                 }
        //             },
        //             Unidade = new Unidade{
        //                 Nome = "",
        //                 SAP = ""
        //             },
        //             CentroCusto = "",
        //             Data = new DateTime(2016,1,1),
        //             Periodo = TimeSpan.FromHours(12D),
        //             Status = new StatusLancamento{
        //                 Descricao = "NF Recebida > PT&P"
        //             }
        //         }
        //     };
        // }
    }
}