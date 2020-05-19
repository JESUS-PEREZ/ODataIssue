using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using ODataInheritanceIssue.Repositories;

namespace ODataInheritanceIssue

{
    public class RelationshipsController : ODataController
    {
        private readonly RelationshipRepository relationshipRepository;

        public RelationshipsController()
        {
            this.relationshipRepository = new RelationshipRepository();
        }

        [EnableQuery]
        public IActionResult Get()
        {
            return Ok(this.relationshipRepository.GetRelationships());
        }
    }
}
