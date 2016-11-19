using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class userMap : EntityTypeConfiguration<user>
    {
        public userMap()
        {
            // Primary Key
            this.HasKey(t => t.idUser);

            // Properties
            this.Property(t => t.DTYPE)
                .IsRequired()
                .HasMaxLength(31);

            this.Property(t => t.idUser)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.email)
                .HasMaxLength(255);

            this.Property(t => t.firstName)
                .HasMaxLength(255);

            this.Property(t => t.gender)
                .HasMaxLength(255);

            this.Property(t => t.lastName)
                .HasMaxLength(255);

            this.Property(t => t.login)
                .HasMaxLength(255);

            this.Property(t => t.password)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("user", "crowd");
            this.Property(t => t.DTYPE).HasColumnName("DTYPE");
            this.Property(t => t.idUser).HasColumnName("idUser");
            this.Property(t => t.ban).HasColumnName("ban");
            this.Property(t => t.birthday).HasColumnName("birthday");
            this.Property(t => t.email).HasColumnName("email");
            this.Property(t => t.firstName).HasColumnName("firstName");
            this.Property(t => t.gender).HasColumnName("gender");
            this.Property(t => t.inscriptionDate).HasColumnName("inscriptionDate");
            this.Property(t => t.lastName).HasColumnName("lastName");
            this.Property(t => t.login).HasColumnName("login");
            this.Property(t => t.password).HasColumnName("password");
            this.Property(t => t.tel).HasColumnName("tel");
            this.Property(t => t.idCustomer).HasColumnName("idCustomer");
            this.Property(t => t.score).HasColumnName("score");
            this.Property(t => t.idManager).HasColumnName("idManager");
            this.Property(t => t.idReviewer).HasColumnName("idReviewer");
            this.Property(t => t.manager_idUser).HasColumnName("manager_idUser");
        }
    }
}
