namespace MangaUpdater.Domain.AniList
{
    public class AniListEdge<TNode> where TNode : class
    {
        public TNode? Node { get; set; }
        public int? Id { get; set; }
        public int? FavouriteOrder { get; set; }
    }
}