using System.Text.Json;

namespace lukaszynal.Models
{
    public class ProjectModel
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string[]? Description { get; set; }
        public string[]? TechStack { get; set; }
        public string? Github { get; set; }
        public string? Img { get; set; }
        public string? Date { get; set; }

        public override string ToString() => JsonSerializer.Serialize(this);
    }
}
