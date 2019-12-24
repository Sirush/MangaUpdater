namespace MangaUpdater.Domain.AniList
{
    public class AniListFavourites
    {
        public AniListMediaConnection? Anime { get; set; }
        public AniListMediaConnection? Manga { get; set; }
        public AniListCharacterConnection? Characters { get; set; }
        public AniListStaffConnection? Staff { get; set; }
        public AniListStudioConnection? Studios { get; set; }
    }
}