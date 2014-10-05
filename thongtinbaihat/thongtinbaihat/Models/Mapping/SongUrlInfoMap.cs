using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace thongtinbaihat.Models.Mapping
{
    public class SongUrlInfoMap : EntityTypeConfiguration<SongUrlInfo>
    {
        public SongUrlInfoMap()
        {
            // Primary Key
            this.HasKey(t => t.UrlId);
          
            // Table & Column Mappings
            this.ToTable("SongUrlInfo");
            this.Property(t => t.UrlId).HasColumnName("UrlId");
            this.Property(t => t.Url).HasColumnName("Url");
            this.Property(t => t.IsCertified).HasColumnName("IsCertified");            
        }
    }
}