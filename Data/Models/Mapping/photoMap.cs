using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class photoMap : EntityTypeConfiguration<photo>
    {
        public photoMap()
        {
            // Primary Key
            this.HasKey(t => t.idPhoto);

            // Properties
            this.Property(t => t.idPhoto)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Picture)
                .HasMaxLength(255);

            this.Property(t => t.description)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("photo", "crowd");
            this.Property(t => t.idPhoto).HasColumnName("idPhoto");
            this.Property(t => t.Picture).HasColumnName("Picture");
            this.Property(t => t.date).HasColumnName("date");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.customer_idUser).HasColumnName("customer_idUser");
            this.Property(t => t.manager_idUser).HasColumnName("manager_idUser");
        }
    }
}
