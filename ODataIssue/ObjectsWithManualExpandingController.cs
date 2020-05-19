using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using ODataInheritanceIssue.Database;
using ODataInheritanceIssue.Repositories;

namespace ODataInheritanceIssue

{
    public class ObjectsWithManualExpandingController : ODataController
    {
        private readonly ObjectRepository objectRepository;

        public ObjectsWithManualExpandingController(TestDBContext database)
        {
            this.objectRepository = new ObjectRepository(database);
        }

        [EnableQuery]
        public IActionResult Get()
        {
            return Ok(this.objectRepository.GetObjects(attributeValuesExpanded: true));
        }
    }
}
