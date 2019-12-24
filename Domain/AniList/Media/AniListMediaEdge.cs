using System.Collections.Generic;

namespace MangaUpdater.Domain.AniList
{
    public class AniListMediaEdge : AniListEdge<AniListMedia>
    {
        public AniListMediaRelation? RelationType { get; set; }
        public bool IsMainStudio { get; set; }
        public List<AniListCharacter>? Characters { get; set; }
        public AniListCharacterRole? CharacterRole { get; set; }
        public string? StaffRole { get; set; }
        public List<AniListStaff>? VoiceActors { get; set; }
    }
}