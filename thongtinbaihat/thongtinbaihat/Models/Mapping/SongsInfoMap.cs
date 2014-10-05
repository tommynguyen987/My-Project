using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace thongtinbaihat.Models.Mapping
{
    public class SongsInfoMap : EntityTypeConfiguration<SongsInfo>
    {
        public SongsInfoMap()
        {
            // Primary Key
            this.HasKey(t => t.SongId);

            // Properties
            this.Property(t => t.SongName)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("SongsInfo");
            this.Property(t => t.SongId).HasColumnName("SongId");
            this.Property(t => t.SongName).HasColumnName("SongName");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.LyricsId).HasColumnName("LyricsId");
            this.Property(t => t.UrlId).HasColumnName("UrlId");            
        }
    }
}