namespace MangaUpdater.Domain.AniList
{
    public class AniListStudio
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsAnimationStudio { get; set; }
        public AniListMediaConnection? MediaConnection { get; set; }
        public string? SiteUrl { get; set; }
        public bool IsFavourite { get; set; }
        public int? Favourites { get; set; }
    }
}