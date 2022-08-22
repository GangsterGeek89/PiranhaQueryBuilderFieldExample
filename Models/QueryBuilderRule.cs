namespace vuequery.Models
{
    public class QueryBuilderRule
    {
        public string Type { get; set; } = string.Empty;
        public string Id { get; set; } = string.Empty;
        public string Label { get; set; } = string.Empty;
        public IList<string> Operators { get; set; } = new List<string>();
        public IList<QueryBuilderChoice> Choices { get; set; } = new List<QueryBuilderChoice>();
    }
}
