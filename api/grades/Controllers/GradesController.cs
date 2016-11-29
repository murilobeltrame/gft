using System.Collections.Generic;
using grades.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace grades.Controllers
{
    [Route("api/[controller]")]
    public class GradesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<Grade> Get()
        {
            return new GFTContext().Grade;
        }
    }
}