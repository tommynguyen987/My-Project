using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace thongtinbaihat.Models
{
    public partial class SongUrlInfo
    {
        public int UrlId { get; set; }
        public string Url { get; set; }
        public bool IsCertified { get; set; }
    }
}