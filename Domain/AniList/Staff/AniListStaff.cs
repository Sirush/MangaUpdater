namespace MangaUpdater.Domain.AniList
{
    public class AniListStaff
    {
        public int Id { get; set; }
        public AniListStaffName? Name { get; set; }
        public AniListStaffLanguage? Language { get; set; }
        public AniListStaffImage? Image { get; set; }
        public string? Description { get; set; }
        public bool IsFavourite { get; set; }
        public AniListMediaConnection? StaffMedia { get; set; }
        public AniListCharacterConnection? Characters { get; set; }

        public AniListStaff? Staff { get; set; }

        public AniListUser? User { get; set; }
        public int? SubmissionStatus { get; set; }
        public string? SubmissionNotes { get; set; }
        public int? Favourites { get; set; }
    }
}