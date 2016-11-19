using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class reclamationMap : EntityTypeConfiguration<reclamation>
    {
        public reclamationMap()
        {
            // Primary Key
            this.HasKey(t => t.idReclamation);

            // Properties
            this.Property(t => t.content)
                .HasMaxLength(255);

            this.Property(t => t.subject)
                .HasMaxLength(255);

            this.Property(t => t.type)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("reclamation", "crowd");
            this.Property(t => t.idReclamation).HasColumnName("idReclamation");
            this.Property(t => t.content).HasColumnName("content");
            this.Property(t => t.dateReclamation).HasColumnName("dateReclamation");
            this.Property(t => t.subject).HasColumnName("subject");
            this.Property(t => t.customer_idUser).HasColumnName("customer_idUser");
            this.Property(t => t.manager_idUser).HasColumnName("manager_idUser");
            this.Property(t => t.type).HasColumnName("type");
        }
    }
}
