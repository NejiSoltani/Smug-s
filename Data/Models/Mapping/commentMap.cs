using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class commentMap : EntityTypeConfiguration<comment>
    {
        public commentMap()
        {
            // Primary Key
            this.HasKey(t => t.idComment);

            // Properties
            this.Property(t => t.idComment)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.content)
                .HasMaxLength(255);


            // Table & Column Mappings
            this.ToTable("comment", "crowd");
            this.Property(t => t.idComment).HasColumnName("idComment");
            this.Property(t => t.content).HasColumnName("content");
 
            this.Property(t => t.date).HasColumnName("date");
            this.Property(t => t.customer_idUser).HasColumnName("customer_idUser");
            this.Property(t => t.idea_idIdea).HasColumnName("idea_idIdea");
            this.Property(t => t.manager_idUser).HasColumnName("manager_idUser");
            this.Property(t => t.photo_idPhoto).HasColumnName("photo_idPhoto");
            this.Property(t => t.reported).HasColumnName("reported");
        }
    }
}
