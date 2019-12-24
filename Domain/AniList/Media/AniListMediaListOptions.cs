namespace MangaUpdater.Domain.AniList
{
    public class AniListMediaListOptions
    {
        public AniListScoreFormat? ScoreFormat { get; set; }
        public string? RowOrder { get; set; }
        public bool? UseLegacyLists { get; set; }
        public AniListMediaListTypeOptions? AnimeList { get; set; }
        public AniListMediaListTypeOptions? MangaList { get; set; }
    }
}