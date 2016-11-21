using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class NotificationMap : EntityTypeConfiguration<notification>
    {
        public NotificationMap()
        {
            // Primary Key
            this.HasKey(t => t.idNotification);

            this.Property(t => t.idNotification)
    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            this.Property(t => t.content)
    .HasMaxLength(255);
            // Properties
            // Table & Column Mappings
            this.ToTable("notification", "crowd");
            this.Property(t => t.idNotification).HasColumnName("idNotification");
            this.Property(t => t.date).HasColumnName("date");
            this.Property(t => t.content).HasColumnName("content");
            this.Property(t => t.customer_idUser).HasColumnName("customer_idUser");
            this.Property(t => t.reviewer_idUser).HasColumnName("reviewer_idUser");
        }
    }
}
