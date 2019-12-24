using System;

namespace MangaUpdater.Domain.AniList
{
    public class AniListMediaList
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int MediaId { get; set; }

        /// <summary>
        /// The watching/reading status
        /// </summary>
        public AniListMediaListStatus? Status { get; set; }

        public float? Score { get; set; }

        /// <summary>
        /// The amount of episodes/chapters consumed by the user
        /// </summary>
        public int? Progress { get; set; }

        /// <summary>
        /// The amount of volumes read by the user
        /// </summary>
        public int? ProgressVolumes { get; set; }

        /// <summary>
        /// The amount of times the user has rewatched/read the media
        /// </summary>
        public int? Repeat { get; set; }

        /// <summary>
        /// Priority of planning
        /// </summary>
        public int? Priority { get; set; }

        /// <summary>
        /// If the entry should only be visible to authenticated user
        /// </summary>
        public bool? Private { get; set; }

        /// <summary>
        /// Text notes
        /// </summary>
        public string? Notes { get; set; }

        /// <summary>
        /// If the entry shown be hidden from non-custom lists
        /// </summary>
        public bool? HiddenFromStatusLists { get; set; }

        /// <summary>
        /// Map of advanced scores with name keys
        /// </summary>
        public string? AdvancedScores { get; set; }

        public DateTime? StartedAt { get; set; }
        public DateTime? CompletedAt { get; set; }
        public int? UpdatedAt { get; set; }
        public int? CreatedAt { get; set; }
        public AniListMedia? Media { get; set; }
        public AniListUser? User { get; set; }
    }
}