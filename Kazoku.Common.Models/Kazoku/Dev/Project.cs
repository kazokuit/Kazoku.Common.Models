using Newtonsoft.Json;

namespace Kazoku.Common.Models.Kazoku.Dev
{
    public class Project
    {
        [JsonProperty("id")]
        public Guid Id { get; private set; }
        
        [JsonProperty("name")]
        public string Name { get; set; } = string.Empty;
        
        [JsonProperty("image")]
        public string? Image { get; set; }
        
        [JsonProperty("description")]
        public string? Description { get; set; } = string.Empty;
        
        [JsonProperty("status")]
        public Status Status { get; set; } = Status.Backlog;
        
        [JsonProperty("url")]
        public string Url { get; set; } = string.Empty;
        
        [JsonProperty("created")]
        public DateTimeOffset Created { get; set; } = DateTimeOffset.Now;

        [JsonProperty("updated")]
        public DateTimeOffset? Updated { get; set; }

        [JsonProperty("deleted")]
        public DateTimeOffset? Deleted { get; set; }

        [JsonProperty("views")]
        public long Views { get; private set; } = 0;

        [JsonProperty("shares")]
        public long Shares { get; private set; } = 0;
    }
}
