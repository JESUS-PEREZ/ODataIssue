using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ODataInheritanceIssue.Models;

namespace ODataInheritanceIssue.Database.Configurations
{
    public class AttributeValueConfiguration
        : IEntityTypeConfiguration<AttributeValue>
    {
        public void Configure(EntityTypeBuilder<AttributeValue> builder)
        {
            builder.HasKey(e => e.AttributeValueId);

            builder
                .HasDiscriminator<int>(nameof(AttributeCategory))
                .HasValue<TextAttributeValue>((int)AttributeCategory.Text)
                .HasValue<ChoiceAttributeValue>((int)AttributeCategory.Choice)
                .HasValue<HyperlinkAttributeValue>((int)AttributeCategory.Hyperlink);
        }
    }
}
