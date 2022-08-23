using Piranha.AttributeBuilder;
using Piranha.Extend;
using Piranha.Models;
using System.Collections.Immutable;

namespace vuequery.Models
{
    [PageType(Title = "Standard page")]
    public class StandardPage  : Page<StandardPage>
    {
        [Region(Title = "The query builder field")]
        public QueryBuilderField Query { get; set; }

    }

}