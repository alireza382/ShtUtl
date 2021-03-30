using System;
using System.Collections.Generic;
using System.Text;
using ShtUrl.Domain.Models;
namespace ShtUrl.Application.Interfaces
{
    public interface IShoorteenUrl
    {
        public string GetShoorteenUrl(string originalUrl);

        public string getOriginalUrl(string shoorteenUrl);

        public IEnumerable<ShorteenUrl> GetAllUrl();
    }
}
