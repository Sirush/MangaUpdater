using System.Collections.Generic;
using System.Threading.Tasks;
using MangaUpdater.Domain.AniList;

namespace MangaUpdater.Repositories
{
    public interface IAniListRepository
    {
        Task<AniListUser> GetUser();
        Task<AniListMedia> GetMediaById(int id);
        Task<List<AniListMedia>> GetMediasByName(string name, int page, int perPage);
    }
}