using System.Collections.Generic;

namespace MangaUpdater.Domain.AniList
{
    public class AniListUserBaseStatistic
    {
        public int Count { get; set; }
        public float MeanScore { get; set; }
        public int MinutesWatched { get; set; }
        public int ChaptersRead { get; set; }
        public List<int> MediaIds { get; set; }
    }
}