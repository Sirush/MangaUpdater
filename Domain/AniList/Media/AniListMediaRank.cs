namespace MangaUpdater.Domain.AniList
{
    public class AniListMediaRank
    {
        public int Id { get; set; }
        public int Rank { get; set; }
        public AniListMediaRankType Type { get; set; }
        public AniListMediaFormat Format { get; set; }
        public int? Year { get; set; }
        public AniListMediaSeason? Season { get; set; }
        public bool? AllTime { get; set; }
        public string Context { get; set; }
    }
}