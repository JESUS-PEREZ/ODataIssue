using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ODataInheritanceIssue.Models;

namespace ODataInheritanceIssue.Database
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new TestDBContext(
                serviceProvider.GetRequiredService<DbContextOptions<TestDBContext>>()))
            {
                if (context.Objects.Any())
                {
                    return;
                }

                context.Objects.AddRange(
                    new Models.Object
                    {
                        Id = 1,
                        Name = "Object 1",
                        AttributeValues = new List<AttributeValue>
                        {
                            new HyperlinkAttributeValue
                            {
                                AttributeValueId = 1,
                                ObjectId = 1,
                                AttributeValueCategory = AttributeCategory.Hyperlink,
                                AttributeName = "Description",
                                Values = new List<HyperlinkValue>
                                {
                                    new HyperlinkValue { HyperlinkValueId = 1, DisplayValue = "D1" }
                                }
                            },
                            new ChoiceAttributeValue
                            {
                                AttributeValueId = 2,
                                ObjectId = 2,
                                AttributeValueCategory = AttributeCategory.Choice,
                                AttributeName = "Choice",
                                Values = new List<ChoiceValue>
                                {
                                    new ChoiceValue  { ChoiceValueId = 1, Name = "Choice 1" },
                                    new ChoiceValue  { ChoiceValueId = 2, Name = "Choice 2" }
                                }
                            }
                        }
                    });

                context.SaveChanges();
            }
        }
    }
}
