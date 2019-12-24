namespace MangaUpdater.Domain.AniList
{
    public class AniListUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? About { get; set; }
        public AniListUserAvatar? Avatar { get; set; }
        public string? BannerImage { get; set; }
        public bool? IsFollowing { get; set; }
        public bool? IsFollower { get; set; }
        public bool? IsBlocked { get; set; }
        public string? Bans { get; set; }
        public AniListUserOptions? Options { get; set; }
        public AniListMediaListOptions? MediaListOptions { get; set; }
        public AniListFavourites? Favourites { get; set; }
        public AniListUserStatisticTypes Statistics { get; set; }
        public int? UnreadNotificationCount { get; set; }
        public string? SiteUrl { get; set; }
        public int? DonatorTier { get; set; }
        public string? DonatorBadge { get; set; }
        public string? ModeratorStatus { get; set; }
        public int? UpdatedAt { get; set; }
    }
}