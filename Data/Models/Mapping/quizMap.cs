using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class quizMap : EntityTypeConfiguration<quiz>
    {
        public quizMap()
        {
            // Primary Key
            this.HasKey(t => t.idQuiz);

            // Properties
            // Table & Column Mappings
            this.ToTable("quiz", "crowd");
            this.Property(t => t.idQuiz).HasColumnName("idQuiz");
            this.Property(t => t.endDate).HasColumnName("endDate");
            this.Property(t => t.score).HasColumnName("score");
            this.Property(t => t.startDate).HasColumnName("startDate");
            this.Property(t => t.customer_idUser).HasColumnName("customer_idUser");
            this.Property(t => t.reviewer_idUser).HasColumnName("reviewer_idUser");
        }
    }
}
