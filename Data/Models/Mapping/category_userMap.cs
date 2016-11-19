using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class category_userMap : EntityTypeConfiguration<category_user>
    {
        public category_userMap()
        {
            // Primary Key
            this.HasKey(t => new { t.categories_idCategory, t.customers_idUser });

            // Properties
            this.Property(t => t.categories_idCategory)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.customers_idUser)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("category_user", "crowd");
            this.Property(t => t.categories_idCategory).HasColumnName("categories_idCategory");
            this.Property(t => t.customers_idUser).HasColumnName("customers_idUser");
        }
    }
}
