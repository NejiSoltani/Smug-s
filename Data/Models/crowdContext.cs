using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Data.Models.Mapping;


namespace Data.Models
{
    public partial class crowdContext : DbContext
    {
        static crowdContext()
        {
            Database.SetInitializer<crowdContext>(null);
        }

        public crowdContext()
            : base("Name=crowdContext")
        {
        }
 
        public DbSet<category> categories { get; set; }
        public DbSet<category_customer> category_customer { get; set; }
        public DbSet<category_user> category_user { get; set; }
        public DbSet<comment> comments { get; set; }
        public DbSet<customer> customers { get; set; }
        public DbSet<contact> contacts { get; set; }
        public DbSet<idea> ideas { get; set; }
        public DbSet<ideareviewer> ideareviewers { get; set; }
        public DbSet<like2> like2 { get; set; }
        public DbSet<marketingmanager> marketingmanagers { get; set; }
        public DbSet<photo> photos { get; set; }
        public DbSet<prize> prizes { get; set; }
        public DbSet<product> products { get; set; }
        public DbSet<question> questions { get; set; }
        public DbSet<quiz> quizs { get; set; }
        public DbSet<reclamation> reclamations { get; set; }
        public DbSet<reservation> reservations { get; set; }
        public DbSet<shop> shops { get; set; }
        public DbSet<t_todo> t_todo { get; set; }
        public DbSet<user> users { get; set; }
        public DbSet<dictionary> dictionary { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Configurations.Add(new categoryMap());
            modelBuilder.Configurations.Add(new category_customerMap());
            modelBuilder.Configurations.Add(new category_userMap());
            modelBuilder.Configurations.Add(new commentMap());
            modelBuilder.Configurations.Add(new customerMap());
            modelBuilder.Configurations.Add(new contactMap());
            modelBuilder.Configurations.Add(new ideaMap());
            modelBuilder.Configurations.Add(new ideareviewerMap());
            modelBuilder.Configurations.Add(new like2Map());
            modelBuilder.Configurations.Add(new marketingmanagerMap());
            modelBuilder.Configurations.Add(new photoMap());
            modelBuilder.Configurations.Add(new prizeMap());
            modelBuilder.Configurations.Add(new productMap());
            modelBuilder.Configurations.Add(new questionMap());
            modelBuilder.Configurations.Add(new quizMap());
            modelBuilder.Configurations.Add(new reclamationMap());
            modelBuilder.Configurations.Add(new reservationMap());
            modelBuilder.Configurations.Add(new shopMap());
            modelBuilder.Configurations.Add(new t_todoMap());
            modelBuilder.Configurations.Add(new userMap());
            modelBuilder.Configurations.Add(new dictionaryMap());
            // modelBuilder.Entity<comment>().ToTable("comment");

        }
    }
}
