namespace MangaUpdater.Domain.AniList
{
    public class AniListAiringSchedule
    {
        public int Id { get; set; }
        public int AiringAt { get; set; }
        public int TimeUntilAiring { get; set; }
        public int Episode { get; set; }
        public int MediaId { get; set; }
        public AniListMedia? Media { get; set; }
    }
}