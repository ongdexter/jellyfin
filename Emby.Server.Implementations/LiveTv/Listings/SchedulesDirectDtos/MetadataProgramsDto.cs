#nullable disable

using System.Text.Json.Serialization;

namespace Emby.Server.Implementations.LiveTv.Listings.SchedulesDirectDtos
{
    /// <summary>
    /// Metadata programs dto.
    /// </summary>
    public class MetadataProgramsDto
    {
        /// <summary>
        /// Gets or sets the gracenote object.
        /// </summary>
        [JsonPropertyName("gracenote")]
        public GracenoteDto Gracenote { get; set; }
    }
}
