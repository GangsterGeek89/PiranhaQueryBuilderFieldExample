using Piranha.Extend;

namespace vuequery.Models
{
    [FieldType(Name = "Query-Builder-Field", Component = "query-builder-field")]
    public class QueryBuilderField : IField
    {
        public IList<QueryBuilderRule> Rules { get; set; }

        public string GetTitle()
        {
            return "My Custom Query Builder Field";
        }

        public void InitManager()
        {
            Rules = new List<QueryBuilderRule>()
            {
                new QueryBuilderRule
                {
                    Type = "text",
                    Id = "vegetable",
                    Label = "Vegetable",

                },
                new QueryBuilderRule
                {
                    Type = "radio",
                    Id = "fruit",
                    Label = "Fruit",
                    Choices = new List<QueryBuilderChoice>()
                    {
                        new QueryBuilderChoice{Label = "Apple", Value = "apple"},
                        new QueryBuilderChoice{Label = "Banana", Value = "banana"}
                    }
                },
                new QueryBuilderRule
                {
                    Type = "radio",
                    Id = "drink",
                    Label = "Drink",
                    Choices = new List<QueryBuilderChoice>()
                    {
                        new QueryBuilderChoice{Label = "Coffee", Value = "coffee"},
                        new QueryBuilderChoice{Label = "Tea", Value = "tea"},
                        new QueryBuilderChoice{Label = "Water", Value = "water"},
                        new QueryBuilderChoice{Label = "Orange", Value = "orange"}
                    }
                }
            };
        }
    }
}
