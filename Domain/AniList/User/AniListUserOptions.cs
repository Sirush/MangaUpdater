using System.Collections.Generic;

namespace MangaUpdater.Domain.AniList
{
    public class AniListUserOptions
    {
        public AniListUserTitleLanguage? TitleLanguage { get; set; }
        public bool? DisplayAdultContent { get; set; }
        public bool? AiringNotifications { get; set; }
        public string? ProfileColor { get; set; }
        public List<AniListNotificationOption>? NotificationOptions { get; set; }
    }
}