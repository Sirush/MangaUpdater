using System.Collections.Generic;

namespace MangaUpdater.Domain.AniList
{
    public class AniListUserVoiceActorStatistic : AniListUserBaseStatistic
    {
        public AniListStaff? VoiceActor { get; set; }
        public List<int> CharacterIds { get; set; }
    }
}