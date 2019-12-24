namespace MangaUpdater.Domain.AniList
{
    public class AniListCharacter
    {
        public int Id { get; set; }
        public AniListCharacterName? Name { get; set; }
        public AniListCharacterImage? Image { get; set; }
        public string? Description { get; set; }
        public bool IsFavourite { get; set; }
        public string? SiteUrl { get; set; }
        public AniListMediaConnection? Media { get; set; }
        public int? Favourites { get; set; }
    }
}