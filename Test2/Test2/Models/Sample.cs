using System.Data.Entity;

namespace Test2.Models
{
    public class Sample
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class SampleDbContext : DbContext
    {
        public DbSet<Sample> Samples { get; set; }
    }
}