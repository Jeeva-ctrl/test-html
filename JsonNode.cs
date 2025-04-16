public class JsonNode
{
    public string? Key { get; set; }
    public object? Value { get; set; }
    public bool IsChecked { get; set; } = true;
    public List<JsonNode>? Children { get; set; }
}
