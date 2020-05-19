using System.Collections.Generic;

namespace ODataInheritanceIssue.Models
{
    public class ChoiceAttributeValue : AttributeValue
    {
        public IList<ChoiceValue> Values { get; set; }
    }
}
