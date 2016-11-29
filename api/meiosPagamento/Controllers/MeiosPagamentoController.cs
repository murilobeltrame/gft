using System.Collections.Generic;
using GFT.API.MeiosPagamento.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace meiosPagamento.Controllers
{
    [Route("api/[controller]")]
    public class MeiosPagamentoController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<MeioPagamento> Get()
        {
            return new MeioPagamento[] {
                new MeioPagamento { Descricao = "Meio Pagamento A" },
                new MeioPagamento { Descricao = "Meio Pagamento B" },
                new MeioPagamento { Descricao = "Meio Pagamento C" },
                new MeioPagamento { Descricao = "Meio Pagamento D" },
                new MeioPagamento { Descricao = "Meio Pagamento E" },
                new MeioPagamento { Descricao = "Meio Pagamento F" },
                new MeioPagamento { Descricao = "Meio Pagamento G" },
                new MeioPagamento { Descricao = "Meio Pagamento H" },
                new MeioPagamento { Descricao = "Meio Pagamento I" } 
            };
        }
    }
}