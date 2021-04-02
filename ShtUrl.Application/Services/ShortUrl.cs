using ShtUrl.Application.Interfaces;
using ShtUrl.Data.Context;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace ShtUrl.Application.Services
{
    public class ShortUrl : IUrlshoorter
    {
        private readonly ShoorteenUrlDbContext _shoorteenUrlDbContext;

        public ShortUrl(ShoorteenUrlDbContext shoorteenUrlDbContext)
        {
            this._shoorteenUrlDbContext = shoorteenUrlDbContext;
        }

        public string GetRandomUrl()
        {
            int numbers = GetMaxLengthUrls();
            Random random = new Random();
            string shortUrl = String.Empty;
            while (true)
            {
                for (int i = 0; i <= numbers; i++)
                {
                    if (random.Next(1, 10) % 2 == 0)
                        shortUrl += (char)random.Next(65, 78);
                    else
                        shortUrl += (char)random.Next(97, 122);
                }
                if (IsRepetative(shortUrl)) break;

            }
          
          
          
            return shortUrl;
        }

        public int GetMaxLengthUrls()
        {
            int idMax;
            var id = _shoorteenUrlDbContext.shorteenUrls.Select(x => x.Id).ToList();
            if (id.Count == 0)
                idMax = 1;
            else
                 idMax = id.Max();
             int CountOfdigit = (int) Math.Floor(Math.Log10(idMax) + 1);
            return idMax  + 3;
        }
        public bool IsRepetative(string shorturl)
        {
            var result = _shoorteenUrlDbContext.shorteenUrls.Where(x => x.ShortUrl.Equals(shorturl));
            return !(result == null);

        }
    }
}
