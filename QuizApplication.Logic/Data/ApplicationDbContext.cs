using System.Data.Entity;
using QuizApplication.Logic.Model;


namespace QuizApplication.Logic.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("QuizApp")
        {

        }

        public DbSet<PersonModel> Person { get; set; }
    }
}
