using System;
using System.Collections.Generic;

namespace Indexers
{
    public class HttpCookie
    {
        private readonly Dictionary<string, string> _dicitionary;
        public DateTime Expiry { get; set; }

        public HttpCookie()
        {
            _dicitionary = new Dictionary<string, string>();
        }

        public string this[string key]
        {
            get => _dicitionary[key];
            set { _dicitionary[key] = value; }
        }
    }
}