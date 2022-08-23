using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Piranha.Extend;

namespace vuequery.Models
{
    [FieldType(Name = "Query-Builder-Field", Component = "query-builder-field")]
    public class QueryBuilderField : IField
    {
        public IList<QueryBuilderRule> Rules { get; set; }

        public JObject Query { get; set; } = new JObject();

        public string GetTitle()
        {
            return "My Custom Query Builder Field";
        }

        public void InitManager()
        {
            if (Rules != null && Rules.Any())
                return;

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
                },
                new QueryBuilderRule
                {
                    Type = "select",
                    Id = "transport",
                    Label = "Transport",
                    Choices = new List<QueryBuilderChoice>()
                    {
                        new QueryBuilderChoice{Label = "Bus", Value = "bus"},
                        new QueryBuilderChoice{Label = "Train", Value = "train"},
                        new QueryBuilderChoice{Label = "Car", Value = "car"},
                        new QueryBuilderChoice{Label = "Walk", Value = "walk"}
                    }
                }
            };

            
        }
    }
}
