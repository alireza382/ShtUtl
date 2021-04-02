using ShtUrl.Data.Context;
using ShtUrl.Domain.Models;
using System;
using System.Threading;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ShtUrl.Data.DataServices
{
    public class DataService : IDataService
    {
        private readonly ShoorteenUrlDbContext _shoorteenUrlDbContext;

        public DataService(ShoorteenUrlDbContext shoorteenUrlDbContext)
        {
            this._shoorteenUrlDbContext = shoorteenUrlDbContext;
        }
        public Task<ShorteenUrl> GetOriginalUrl(string shorturl)
        {
            var result = _shoorteenUrlDbContext.shorteenUrls.FirstOrDefaultAsync(x=>x.ShortUrl == shorturl);
            return result;
        }

        public Task<List<ShorteenUrl>> GetAllshorteenUrls()
        {
            var result = _shoorteenUrlDbContext.shorteenUrls.Where(x=>x.Id>0).ToListAsync();
            return result;
        }

        public Task<List<ShorteenUrl>> GetShortUrlByOriginal(string originalUrl)
        {
            var result =  _shoorteenUrlDbContext.shorteenUrls.Where(x=>x.OriginalUrl == originalUrl).ToListAsync();
            return result;
        }

        public async Task<bool> Savechanges(string originalUrl, string shortUrl)
        {
            var result = new ShorteenUrl()
            {
                OriginalUrl = originalUrl,
                ShortUrl = shortUrl

            };

            _shoorteenUrlDbContext.shorteenUrls.Add(result);
            int i = await _shoorteenUrlDbContext.SaveChangesAsync();

            return (i == 0) ? false : true;

        }

        

       
    }
}
