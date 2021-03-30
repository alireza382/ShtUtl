using System;
using System.Collections.Generic;
using System.Text;

namespace ShtUrl.Application.Interfaces
{
    public interface IUrlshoorter
    {

        public string GetRandomUrl();

        public int GetMaxLengthUrls();

        public bool IsRepetative(string shorturl);

    }
}
