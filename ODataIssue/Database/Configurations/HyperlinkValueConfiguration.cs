using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ODataInheritanceIssue.Models;

namespace ODataInheritanceIssue.Database.Configurations
{
    public class HyperlinkValueConfiguration
        : IEntityTypeConfiguration<HyperlinkValue>
    {
        public void Configure(EntityTypeBuilder<HyperlinkValue> builder)
        {
            builder.HasKey(x => x.HyperlinkValueId);
        }
    }
}
