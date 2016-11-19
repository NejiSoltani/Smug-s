using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class productMap : EntityTypeConfiguration<product>
    {
        public productMap()
        {
            // Primary Key
            this.HasKey(t => t.idProduct);

            // Properties
            this.Property(t => t.idProduct)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.description)
                .HasMaxLength(255);

            this.Property(t => t.name)
                .HasMaxLength(255);

            this.Property(t => t.photo)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("product", "crowd");
            this.Property(t => t.idProduct).HasColumnName("idProduct");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.photo).HasColumnName("photo");
            this.Property(t => t.price).HasColumnName("price");
            this.Property(t => t.score).HasColumnName("score");
            this.Property(t => t.category_idCategory).HasColumnName("category_idCategory");
        }
    }
}
