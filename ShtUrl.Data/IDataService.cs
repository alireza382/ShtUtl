using ShtUrl.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShtUrl.Data
{
     public interface IDataService
    {
        public Task<bool> Savechanges(string originalUrl,string shortUrl);

        public  Task<List<ShorteenUrl>> GetAllshorteenUrls();

        public Task<ShorteenUrl> GetOriginalUrl(string shorturl);

        public Task<List<ShorteenUrl>> GetShortUrlByOriginal(string ShortUrl);
    }
}
