using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class questionMap : EntityTypeConfiguration<question>
    {
        public questionMap()
        {
            // Primary Key
            this.HasKey(t => t.idQuestion);

            // Properties
            this.Property(t => t.idQuestion)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.answer)
                .HasMaxLength(255);

            this.Property(t => t.description)
                .HasMaxLength(255);

            this.Property(t => t.photo)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("question", "crowd");
            this.Property(t => t.idQuestion).HasColumnName("idQuestion");
            this.Property(t => t.answer).HasColumnName("answer");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.photo).HasColumnName("photo");
            this.Property(t => t.quiz_idQuiz).HasColumnName("quiz_idQuiz");
        }
    }
}
