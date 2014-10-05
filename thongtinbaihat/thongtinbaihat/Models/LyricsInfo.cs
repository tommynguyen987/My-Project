using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace thongtinbaihat.Models
{
    public partial class LyricsInfo
    {
        public int LyricsId { get; set; }
        public string Lyrics1 { get; set; }
        public string Lyrics2 { get; set; }
        public string Lyrics3 { get; set; }
        public bool IsCertified { get; set; }
    }
}