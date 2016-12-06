using lancamentos.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Mapster;

namespace lancamentos.Controllers
{
    
    [Route("api/[controller]")]
    public class LancamentosController : Controller
    {
        // GET api/lancamentos
        [HttpGet]
        public IEnumerable<LancamentoDTO> Get(int page = 0)
        {
            var _pagesize = 10;

            return new GFTContext()
                .Lancamento
                .OrderBy(o => o.DtLancamento)
                .Skip(page * _pagesize)
                .Take(_pagesize)
                .ProjectToType<LancamentoDTO>();
        }
    }
}