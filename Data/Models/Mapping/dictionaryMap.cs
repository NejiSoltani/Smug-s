using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class dictionaryMap : EntityTypeConfiguration<dictionary>
    {
        public dictionaryMap()
        {
            // Primary Key
            this.HasKey(t => t.idDictionary);

            // Properties
            this.Property(t => t.idDictionary)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.key)
                .HasMaxLength(255);


            // Table & Column Mappings
            this.ToTable("dictionary", "crowd");
            this.Property(t => t.idDictionary).HasColumnName("idDictionary");
            this.Property(t => t.key).HasColumnName("key");
            this.Property(t => t.val).HasColumnName("val");

        }
    }
}
