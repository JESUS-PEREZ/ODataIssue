using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ODataInheritanceIssue.Models;

namespace ODataInheritanceIssue.Database.Configurations
{
    public class ChoiceValueConfiguration
        : IEntityTypeConfiguration<ChoiceValue>
    {
        public void Configure(EntityTypeBuilder<ChoiceValue> builder)
        {
            builder.HasKey(x => x.ChoiceValueId);
        }
    }
}
