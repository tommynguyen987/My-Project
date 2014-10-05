using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace thongtinbaihat.Models
{
    public partial class SongsInfo
    {
        public int SongId { get; set; }
        public string SongName { get; set; }
        public int UserId { get; set; }
        public int LyricsId { get; set; }
        public int UrlId { get; set; }
    }
}