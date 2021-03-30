using Microsoft.AspNetCore.Mvc;
using ShtUrl.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShtUrl.API.Controllers
{

    [Route("api/[Controller]")]
    [ApiController]
    public class UrlController : ControllerBase
    {


        private readonly ShoorteenUrlDbContext _shoorteenUrlDbContext;
        public UrlController(ShoorteenUrlDbContext shoorteenUrlDbContext)
        {

            this._shoorteenUrlDbContext = shoorteenUrlDbContext;

        }

        [HttpGet("{OriginalUrl}")]
        public ActionResult<string> GetShoorteenUrl(string originalUrl)
        {


        }
    }
}
