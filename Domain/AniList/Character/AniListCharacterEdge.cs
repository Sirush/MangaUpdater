using System.Collections.Generic;

namespace MangaUpdater.Domain.AniList
{
    public class AniListCharacterEdge : AniListEdge<AniListCharacter>
    {
        public AniListCharacterRole? Role { get; set; }
        public List<AniListStaff>? VoiceActors { get; set; }
        public List<AniListMedia>? Media { get; set; }
    }
}