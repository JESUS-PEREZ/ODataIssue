# ODataIssue

The aim of this sample repository is to demonstrate an issue with odata + EF when expanding an oData complex type collection in navigation property.

#### Steps to reproduce the issue

**First scenario:**
1. Run the project.

2. Run the following query: `odata/objects?$expand=AttributeValues`

3. AttributeValue "Values" property is not populated.


**Second scenario:**
1. Run the project.

2. Run the following query: `odata/objectsWithManualExpanding?$expand=AttributeValues`

3. AttributeValue "Values" property is populated because the entity has been manually expanded by code.

4. Run the following query: `odata/objectsWithManualExpanding?$expand=AttributeValues&$select=AttributeValues`

5. AttributeValue "Values" property is no longer populated.
