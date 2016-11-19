using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class reservationMap : EntityTypeConfiguration<reservation>
    {
        public reservationMap()
        {
            // Primary Key
            this.HasKey(t => t.idReservation);

            // Properties
            this.Property(t => t.idReservation)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.description)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("reservation", "crowd");
            this.Property(t => t.idReservation).HasColumnName("idReservation");
            this.Property(t => t.date).HasColumnName("date");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.number).HasColumnName("number");
            this.Property(t => t.customer_idUser).HasColumnName("customer_idUser");
            this.Property(t => t.shop_idShop).HasColumnName("shop_idShop");
        }
    }
}
