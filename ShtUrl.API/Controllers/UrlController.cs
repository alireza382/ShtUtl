using Microsoft.AspNetCore.Mvc;
using ShtUrl.Application.Interfaces;
using ShtUrl.Data.Context;
using ShtUrl.Domain.Models;
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

        private readonly IShoorteenUrl _shoorteenUrl;
        private readonly ShoorteenUrlDbContext _shoorteenUrlDbContext;
        public UrlController(ShoorteenUrlDbContext shoorteenUrlDbContext, IShoorteenUrl shoorteenUrl)
        {
            this._shoorteenUrl = shoorteenUrl;
            this._shoorteenUrlDbContext = shoorteenUrlDbContext;

        }

        [HttpPost]

        public ActionResult<string> GetShoorteenUrl(string originalUrl)
        {
            string shortUrl = _shoorteenUrl.GetShoorteenUrl(originalUrl);
            return shortUrl;


        }


        [HttpPost("GetAll")]
        public ActionResult<IEnumerable<ShorteenUrl>> GetAllUrl()
        {
            List<ShorteenUrl> allUrls = new List<ShorteenUrl>();

            allUrls = _shoorteenUrl.GetAllUrl().ToList();

            return allUrls;
        }

        [HttpPost("original")]
        public ActionResult<String> GetOriginalUrl(string shortenUrl)
        {

            string originalUrl  =  _shoorteenUrl.getOriginalUrl(shortenUrl);
            return originalUrl;
        }
    }
}
