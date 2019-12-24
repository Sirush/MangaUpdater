using System.Collections.Generic;

namespace MangaUpdater.Domain.AniList
{
    public class AnimeListUserStatistics
    {
        public int Count { get; set; }
        public float MeanScore { get; set; }
        public float StandardDeviation { get; set; }
        public int MinutesWatched { get; set; }
        public int EpisodesWatched { get; set; }
        public int ChaptersRead { get; set; }
        public int VolumeRead { get; set; }
        public List<AniListUserFormatStatistic>? Formats { get; set; }
        public List<AniListUserStatusStatistic>? Statuses { get; set; }
        public List<AniListUserScoreStatistic>? Scores { get; set; }
        public List<AniListUserLengthStatistic>? Lengths { get; set; }
        public List<AniListUserReleaseYearStatistic>? ReleaseYears { get; set; }
        public List<AniListUserStartYearStatistic>? StartYears { get; set; }
        public List<AniListUserGenreStatistic>? Genres { get; set; }
        public List<AniListUserTagStatistic>? Tags { get; set; }
        public List<AniListUserCountryStatistic>? Countries { get; set; }
        public List<AniListUserVoiceActorStatistic>? VoiceActors { get; set; }
        public List<AniListUserStaffStatistic>? Staff { get; set; }
        public List<AniListUserStudioStatistic>? Studios { get; set; }
    }
}