using Piranha.AttributeBuilder;
using Piranha.Extend;
using Piranha.Models;

namespace vuequery.Models
{
    [PageType(Title = "Standard page")]
    public class StandardPage  : Page<StandardPage>
    {
        [Region(Title = "The query builder field")]
        public QueryBuilderField Query { get; set; }
    }
}