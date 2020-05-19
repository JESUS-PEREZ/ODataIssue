using System.Collections.Generic;

namespace ODataInheritanceIssue.Models
{
    public class Object
    {
        public Object()
        {
            AttributeValues = new List<AttributeValue>();
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public IList<AttributeValue> AttributeValues { get; set; }
    }
}
