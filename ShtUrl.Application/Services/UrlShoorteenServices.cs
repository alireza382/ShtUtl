using ShtUrl.Application.Interfaces;
using ShtUrl.Data.Context;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using ShtUrl.Domain.Models;
using ShtUrl.Data;

namespace ShtUrl.Application.Services
{
    public class UrlShoorteenServices : IShoorteenUrl
    {
        private readonly IDataService _dataService;
        private readonly ShoorteenUrlDbContext _shoorteenUrlDbContext;
        private readonly IUrlshoorter _urlShoorter;

        public UrlShoorteenServices(ShoorteenUrlDbContext shoorteenUrlDbContext, IUrlshoorter urlshoorter, IDataService dataService)
        {
            this._dataService = dataService;
            this._shoorteenUrlDbContext = shoorteenUrlDbContext;
            this._urlShoorter = urlshoorter;
                
        }
        public IEnumerable<ShorteenUrl> GetAllUrl()
        {
            
            return _shoorteenUrlDbContext.shorteenUrls.ToList();
        }

        public string getOriginalUrl(string shoorteenUrl)
        {
            var originalUrlDate = _shoorteenUrlDbContext.shorteenUrls.FirstOrDefault(x => x.ShortUrl == shoorteenUrl);
            if (originalUrlDate == null) return null;
            return originalUrlDate.OriginalUrl;
        }

        public string GetShoorteenUrl(string originalUrl)
        {
            var shortUrl = _urlShoorter.GetRandomUrl();
            _dataService.Savechanges(originalUrl, shortUrl);
            return shortUrl;
        }
    }
}
