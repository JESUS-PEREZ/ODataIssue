namespace ODataInheritanceIssue.Models
{
    public abstract class AttributeValue
    {
        public int AttributeValueId { get; set; }

        public int ObjectId { get; set; }

        public AttributeCategory AttributeValueCategory { get; set; }

        public string AttributeName { get; set; }
    }
}
