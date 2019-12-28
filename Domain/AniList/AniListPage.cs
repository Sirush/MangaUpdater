using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MangaUpdater.Domain.AniList
{
    public class AniListPage
    {
        public AniListPageInfo? PageInfo { get; set; }
        public List<AniListUser>? Users { get; set; }
        public List<AniListMedia>? Media { get; set; }
        public List<AniListCharacter>? Characters { get; set; }
        public List<AniListStaff>? Staff { get; set; }
        public List<AniListStudio>? Studios { get; set; }
        public List<AniListMediaList>? MediaList { get; set; }
        public List<AniListAiringSchedule>? AiringSchedules { get; set; }
        public List<AniListMediaTrend>? MediaTrends { get; set; }
        public List<AniListNotificationType>? Notifications { get; set; }
        public List<AniListUser>? Followers { get; set; }
        public List<AniListUser>? Following { get; set; }
        public List<object>? Activities { get; set; }
        public List<object>? ActivityReplies { get; set; }
        public List<object>? Threads { get; set; }
        public List<object>? ThreadComments { get; set; }
        public List<AniListReview>? Reviews { get; set; }
        public List<AniListRecommendation>? Recommendations { get; set; }
        public List<AniListUser>? Likes { get; set; }
    }
}