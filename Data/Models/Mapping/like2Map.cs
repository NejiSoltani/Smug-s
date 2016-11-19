using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class like2Map : EntityTypeConfiguration<like2>
    {
        public like2Map()
        {
            // Primary Key
            this.HasKey(t => t.idLike);

            // Properties
            // Table & Column Mappings
            this.ToTable("like2", "crowd");
            this.Property(t => t.idLike).HasColumnName("idLike");
            this.Property(t => t.date).HasColumnName("date");
            this.Property(t => t.customer_idUser).HasColumnName("customer_idUser");
            this.Property(t => t.idea_idIdea).HasColumnName("idea_idIdea");
            this.Property(t => t.photo_idPhoto).HasColumnName("photo_idPhoto");
        }
    }
}
