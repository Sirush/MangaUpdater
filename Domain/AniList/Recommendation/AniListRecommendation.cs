namespace MangaUpdater.Domain.AniList
{
    public class AniListRecommendation
    {
        public int Id { get; set; }
        public int? Rating { get; set; }
        public AniListRecommendationRating? UserRating { get; set; }
        public AniListMedia? Media { get; set; }
        public AniListMedia? MediaRecommendation { get; set; }
        public AniListUser? User { get; set; }
    }
}