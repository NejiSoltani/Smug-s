using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class contactMap : EntityTypeConfiguration<contact>
    {
        public contactMap()
        {
            // Primary Key
            this.HasKey(t => t.idContact);

            // Properties
            this.Property(t => t.idContact)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.content)
                .HasMaxLength(255);

            this.Property(t => t.type)
               .HasMaxLength(255);

            this.Property(t => t.etat)
               .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("contact", "crowd");
            this.Property(t => t.idContact).HasColumnName("idContact");
            this.Property(t => t.content).HasColumnName("content");
            this.Property(t => t.date).HasColumnName("date");
            this.Property(t => t.type).HasColumnName("type");
            this.Property(t => t.etat).HasColumnName("etat");
            this.Property(t => t.customer_idUser).HasColumnName("customer_idUser");
            this.Property(t => t.reviewer_idUser).HasColumnName("reviewer_idUser");
        }
    }
}
