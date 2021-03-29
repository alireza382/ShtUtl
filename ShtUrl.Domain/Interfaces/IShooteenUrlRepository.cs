using ShtUrl.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShtUrl.Domain.Interfaces
{
    public interface IShooteenUrlRepository
    {

        public IEnumerable<ShorteenUrl> GetShoorteens();


        public IEnumerable<ShorteenUrl> GetShorteenUrlsByOriginals(string OriginalUrl);

        public string GetOrginalUrlByShortUrl(string shortUrl);


    }
}
