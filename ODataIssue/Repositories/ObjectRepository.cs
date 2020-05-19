using System.Linq;
using Microsoft.EntityFrameworkCore;
using ODataInheritanceIssue.Database;
using ODataInheritanceIssue.Models;

namespace ODataInheritanceIssue.Repositories
{
	public class ObjectRepository
	{
		private readonly TestDBContext database;

		public ObjectRepository(TestDBContext database)
		{
			this.database = database;
		}

		public IQueryable<Object> GetObjects(bool attributeValuesExpanded = false)
		{
			if (!attributeValuesExpanded)
			{
				return database.Objects;
			}

			return database.Objects
				.Include(o => o.AttributeValues)
					.ThenInclude(m => ((HyperlinkAttributeValue)m).Values)
				.Include(x => x.AttributeValues)
					.ThenInclude(m => ((ChoiceAttributeValue)m).Values);
		}
	}
}
