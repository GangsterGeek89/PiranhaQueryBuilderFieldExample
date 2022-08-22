using Piranha.AttributeBuilder;
using Piranha.Models;

namespace vuequery.Models
{
    [PostType(Title = "Standard post")]
    public class StandardPost  : Post<StandardPost>
    {
    }
}