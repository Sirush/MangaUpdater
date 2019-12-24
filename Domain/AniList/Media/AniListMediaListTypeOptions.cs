using System.Collections.Generic;

namespace MangaUpdater.Domain.AniList
{
    public class AniListMediaListTypeOptions
    {
        public List<string>? SectionOrder { get; set; }
        public bool? SplitCompletedSectionByFormat { get; set; }
        public List<string>? CustomLists { get; set; }
        public List<string>? AdvancedScoring { get; set; }
        public bool? AdvancedScoringEnabled { get; set; }
    }
}