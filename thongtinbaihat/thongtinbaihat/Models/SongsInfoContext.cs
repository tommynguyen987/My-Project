using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using thongtinbaihat.Models.Mapping;

namespace thongtinbaihat.Models
{
    public partial class SongsInfoContext : DbContext
    {
        static SongsInfoContext()
        {
            Database.SetInitializer<SongsInfoContext>(null);
        }

        public SongsInfoContext()
            : base("Name=SongsInfoContext")
        {
        }

        public DbSet<SongsInfo> Songs { get; set; }
        public DbSet<UserInfo> Users { get; set; }
        public DbSet<LyricsInfo> Lyrics { get; set; }
        public DbSet<SongUrlInfo> Urls { get; set; }        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new SongsInfoMap());
            modelBuilder.Configurations.Add(new UserInfoMap ());
            modelBuilder.Configurations.Add(new LyricsInfoMap());
            modelBuilder.Configurations.Add(new SongUrlInfoMap());
        }
    }
}