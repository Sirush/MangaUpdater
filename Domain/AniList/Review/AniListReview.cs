namespace MangaUpdater.Domain.AniList
{
    public class AniListReview
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int MediaId { get; set; }
        public AniListMediaType? MediaType { get; set; }
        public string? Summary { get; set; }
        public string? Body { get; set; }
        public int? Rating { get; set; }
        public int? RatingAmount { get; set; }
        public AniListReviewRating UserRating { get; set; }
        public int? Score { get; set; }
        public bool? Private { get; set; }
        public string? SiteUrl { get; set; }
        public int CreatedAt { get; set; }
        public int UpdatedAt { get; set; }
        public AniListUser? User { get; set; }
        public AniListMedia? Media { get; set; }
    }
}