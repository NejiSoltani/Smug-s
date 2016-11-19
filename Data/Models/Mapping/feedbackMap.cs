using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class feedbackMap : EntityTypeConfiguration<feedback>
    {
        public feedbackMap()
        {
            // Primary Key
            this.HasKey(t => t.idFeedBack);

            // Properties
            this.Property(t => t.idFeedBack)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.content)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("feedback", "crowd");
            this.Property(t => t.idFeedBack).HasColumnName("idFeedBack");
            this.Property(t => t.content).HasColumnName("content");
            this.Property(t => t.date).HasColumnName("date");
            this.Property(t => t.customer_idUser).HasColumnName("customer_idUser");
            this.Property(t => t.reviewer_idUser).HasColumnName("reviewer_idUser");
        }
    }
}
