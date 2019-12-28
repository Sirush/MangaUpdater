using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MangaUpdater.Domain.Common;

namespace MangaUpdater.Services
{
    public interface IMediaService
    {
        Task<Media> GetMediaById(int id);
        Task<List<Media>> GetMediasByName(string name);
    }
}