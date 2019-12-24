using System.Collections.Generic;

namespace MangaUpdater.Domain.AniList
{
    public class AniListRecommendationConnection
    {
        public List<AniListRecommendationEdge>? Edges { get; set; }
        public List<AniListRecommendation>? Nodes { get; set; }
        public AniListPageInfo? PageInfo { get; set; }
    }
}