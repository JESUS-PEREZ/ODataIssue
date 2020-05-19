using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ODataInheritanceIssue.Models;

namespace ODataInheritanceIssue.Database.Configurations
{
    public class ChoiceAttributeValueConfiguration
        : IEntityTypeConfiguration<ChoiceAttributeValue>
    {
        public void Configure(EntityTypeBuilder<ChoiceAttributeValue> builder)
        {
        }
    }
}
