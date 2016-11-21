using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class ideaMap : EntityTypeConfiguration<idea>
    {
        public ideaMap()
        {
            // Primary Key
            this.HasKey(t => t.idIdea);

            // Properties
            this.Property(t => t.content)
                .HasMaxLength(255);

            this.Property(t => t.statut)
                .HasMaxLength(255);

            this.Property(t => t.subject)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("idea", "crowd");
            this.Property(t => t.idIdea).HasColumnName("idIdea");
            this.Property(t => t.content).HasColumnName("content");
            this.Property(t => t.dateDepot).HasColumnName("dateDepot");
            this.Property(t => t.statut).HasColumnName("statut");
            this.Property(t => t.subject).HasColumnName("subject");
            this.Property(t => t.isReported).HasColumnName(" isReported");           
            this.Property(t => t.customer_idUser).HasColumnName("customer_idUser");
            this.Property(t => t.manager_idUser).HasColumnName("manager_idUser");
            this.Property(t => t.reviewer_idUser).HasColumnName("reviewer_idUser");
            this.Property(t => t.manager1_idUser).HasColumnName("manager1_idUser");
        }
    }
}
