using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace thongtinbaihat.Models.Mapping
{
    public class LyricsInfoMap : EntityTypeConfiguration<LyricsInfo>
    {
        public LyricsInfoMap()
        {
            // Primary Key
            this.HasKey(t => t.LyricsId);

            // Table & Column Mappings
            this.ToTable("LyricsInfo");
            this.Property(t => t.LyricsId).HasColumnName("LyricsId");
            this.Property(t => t.Lyrics1).HasColumnName("Lyrics1");
            this.Property(t => t.Lyrics2).HasColumnName("Lyrics2");            
            this.Property(t => t.Lyrics3).HasColumnName("Lyrics3");
            this.Property(t => t.IsCertified).HasColumnName("IsCertified");       
        }
    }
}