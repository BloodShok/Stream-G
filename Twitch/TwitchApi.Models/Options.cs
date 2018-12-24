using System;
using System.Collections.Generic;
using System.Text;

namespace Twitch.API.Data
{
    public class Options
    {
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public List<string> Scopes { get; set; } = new List<string>();
        public string RedirectUrl { get; set; }
      
    }
}
