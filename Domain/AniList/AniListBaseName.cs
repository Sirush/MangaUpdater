using System.Collections.Generic;

namespace MangaUpdater.Domain.AniList
{
    public class AniListBaseName
    {
        public string? First { get; set; }
        public string? Last { get; set; }
        public string? Full { get; set; }
        public string? Native { get; set; }
        public List<string>? Alternative { get; set; }
    }
}