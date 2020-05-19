using Microsoft.EntityFrameworkCore;
using ODataInheritanceIssue.Database.Configurations;

namespace ODataInheritanceIssue.Database
{
    public class TestDBContext : DbContext
    {
        public TestDBContext(DbContextOptions<TestDBContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AttributeValueConfiguration());
            modelBuilder.ApplyConfiguration(new ChoiceAttributeValueConfiguration());
            modelBuilder.ApplyConfiguration(new HyperlinkAttributeValueConfiguration());
            modelBuilder.ApplyConfiguration(new HyperlinkValueConfiguration());
            modelBuilder.ApplyConfiguration(new ChoiceValueConfiguration());
        }

        public DbSet<Models.Object> Objects { get; set; }

        public DbSet<Models.AttributeValue> AttributeValues { get; set; }

        public DbSet<Models.ChoiceValue> Choices { get; set; }

        public DbSet<Models.HyperlinkValue> Hyerplinks { get; set; }
    }
}
