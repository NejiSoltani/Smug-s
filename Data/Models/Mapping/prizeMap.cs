using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class prizeMap : EntityTypeConfiguration<prize>
    {
        public prizeMap()
        {
            // Primary Key
            this.HasKey(t => t.idPrize);

            // Properties
            this.Property(t => t.idPrize)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.description)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("prize", "crowd");
            this.Property(t => t.idPrize).HasColumnName("idPrize");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.customer_idUser).HasColumnName("customer_idUser");
            this.Property(t => t.reviewer_idUser).HasColumnName("reviewer_idUser");
        }
    }
}
