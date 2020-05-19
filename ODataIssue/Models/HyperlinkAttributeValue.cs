using System.Collections.Generic;

namespace ODataInheritanceIssue.Models
{
    public class HyperlinkAttributeValue : AttributeValue
    {
        public IList<HyperlinkValue> Values { get; set; }
    }
}
