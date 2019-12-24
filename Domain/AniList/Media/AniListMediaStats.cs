using System.Collections.Generic;

namespace MangaUpdater.Domain.AniList
{
    public class AniListMediaStats
    {
        public List<AniListScoreDistribution>? ScoreDistribution { get; set; }
        public List<AniListStatusDistribution>? StatusDistribution { get; set; }
    }
}