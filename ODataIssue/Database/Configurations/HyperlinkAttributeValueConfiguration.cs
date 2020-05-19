using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ODataInheritanceIssue.Models;

namespace ODataInheritanceIssue.Database.Configurations
{
    public class HyperlinkAttributeValueConfiguration
        : IEntityTypeConfiguration<HyperlinkAttributeValue>
    {
        public void Configure(EntityTypeBuilder<HyperlinkAttributeValue> builder)
        {
        }
    }
}
