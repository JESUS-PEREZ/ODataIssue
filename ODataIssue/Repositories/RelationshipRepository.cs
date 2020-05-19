using System.Collections.Generic;
using System.Linq;
using ODataInheritanceIssue.Models;

namespace ODataInheritanceIssue.Repositories
{
	public class RelationshipRepository
	{
		private static List<Relationship> relationships = new List<Relationship>
		{
			new Relationship
			{
				Id = 1,
				Name = "R1",
				AttributeValues = new List<AttributeValue>
				{
					new ChoiceAttributeValue
					{
						AttributeName = "A1",
						AttributeValueCategory = AttributeCategory.Choice,
						AttributeValueId = 1,
						Values = new List<ChoiceValue>
						{
							new ChoiceValue { Name = "Choice 1", ChoiceValueId = 1 }
						}
					}
				}
			},
			new Relationship
			{
				Id = 2,
				Name = "R2",
				AttributeValues = new List<AttributeValue>
				{
					new HyperlinkAttributeValue
					{
						AttributeName = "A2",
						AttributeValueCategory = AttributeCategory.Hyperlink,
						AttributeValueId = 2,
						Values = new List<HyperlinkValue>
						{
							new HyperlinkValue { DisplayValue = "Display 1", Url = "https://www.google.es" }
						}
					}
				}
			}
		};

		public IQueryable<Relationship> GetRelationships()
			=> relationships.AsQueryable();
	}
}
