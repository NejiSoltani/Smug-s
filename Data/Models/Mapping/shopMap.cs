using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class shopMap : EntityTypeConfiguration<shop>
    {
        public shopMap()
        {
            // Primary Key
            this.HasKey(t => t.idShop);

            // Properties
            this.Property(t => t.idShop)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.address)
                .HasMaxLength(255);

            this.Property(t => t.lat)
                .HasMaxLength(255);

            this.Property(t => t.lng)
                .HasMaxLength(255);

            this.Property(t => t.name)
                .HasMaxLength(255);

            this.Property(t => t.photo)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("shop", "crowd");
            this.Property(t => t.idShop).HasColumnName("idShop");
            this.Property(t => t.address).HasColumnName("address");
            this.Property(t => t.lat).HasColumnName("lat");
            this.Property(t => t.lng).HasColumnName("lng");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.phone).HasColumnName("phone");
            this.Property(t => t.photo).HasColumnName("photo");
            this.Property(t => t.score).HasColumnName("score");
            this.Property(t => t.category_idCategory).HasColumnName("category_idCategory");
        }
    }
}
