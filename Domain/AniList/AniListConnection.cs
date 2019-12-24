using System.Collections.Generic;

namespace MangaUpdater.Domain.AniList
{
    public class AniListConnection<TEdge, TNode> where TEdge : class where TNode : class
    {
        public List<TEdge>? Edges { get; set; }
        public List<TNode>? Nodes { get; set; }
        public AniListPageInfo? PageInfo { get; set; }
    }
}