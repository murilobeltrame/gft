using System;
using System.Collections.Generic;
// using GFT.API.Lancamentos.Models;
using Microsoft.AspNetCore.Mvc;

namespace lancamentos.Controllers
{
    
    [Route("api/[controller]")]
    public class LancamentosController : Controller
    {
        // GET api/lancamentos
        [HttpGet]
        public IEnumerable<ApontamentoViewModel> Get()
        {
            
        }
    }
}