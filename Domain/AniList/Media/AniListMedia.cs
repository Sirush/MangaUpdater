using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MangaUpdater.Domain.AniList
{
    public class AniListMedia
    {
        public uint Id { get; set; }

        public uint? IdMal { get; set; }

        public AniListMediaTitle? Title { get; set; }

        public AniListMediaType? Type { get; set; }

        public AniListMediaFormat? Format { get; set; }

        public AniListMediaStatus? Status { get; set; }

        public string? Description { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public AniListMediaSeason? Season { get; set; }
        public int? SeasonYear { get; set; }
        public int? SeasonInt { get; set; }
        public int? Episodes { get; set; }
        public int? Duration { get; set; }
        public int? Chapters { get; set; }
        public int? Volumes { get; set; }
        public string? CountryOfOrigin { get; set; }
        public bool? IsLicensed { get; set; }
        public AniListMediaSource? Source { get; set; }

        public string? Hashtag { get; set; }

        public AniListMediaTrailer? Trailer { get; set; }
        public int? UpdatedAt { get; set; }
        public AniListMediaCoverImage? CoverImage { get; set; }
        public string? BannerImage { get; set; }
        public List<string>? Genres { get; set; }
        public List<string>? Synonyms { get; set; }
        public int? AverageScore { get; set; }
        public int? MeanScore { get; set; }
        public int? Popularity { get; set; }
        public bool? IsLocked { get; set; }
        public int? Trending { get; set; }
        public int? Favourites { get; set; }
        public List<AniListMediaTag>? Tags { get; set; }

        public AniListMediaConnection? Relations { get; set; }
        public AniListCharacterConnection? Characters { get; set; }
        public AniListStaffConnection? StaffConnection { get; set; }
        public AniListStudioConnection? Studios { get; set; }
        public bool IsFavourite { get; set; }
        public bool? IsAdult { get; set; }
        public AniListAiringSchedule? NextAiringEpisode { get; set; }
        public AniListAiringScheduleConnection? AiringSchedule { get; set; }
        public AniListMediaTrendConnection? Trends { get; set; }
        public List<AniListMediaExternalLink>? ExternalLinks { get; set; }
        public List<AniListMediaStreamingEpisode>? StreamingEpisodes { get; set; }
        public List<AniListMediaRank>? Rankings { get; set; }
        public AniListMediaList? MediaListEntry { get; set; }
        public AniListReviewConnection? Reviews { get; set; }
        public AniListRecommendationConnection? Recommendations { get; set; }
        public AniListMediaStats Stats { get; set; }
        public string? SiteUrl { get; set; }
        public bool? AutoCreateForumThread { get; set; }
        public bool? IsRecommendationBlocked { get; set; }
        public string? ModNotes { get; set; }
    }
}