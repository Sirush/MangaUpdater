using System.Collections.Generic;
using System.Threading.Tasks;
using Carlabs.Getit;
using MangaUpdater.Domain.AniList;
using MangaUpdater.Utils;

namespace MangaUpdater.Repositories
{
    public class AniListRepository : IAniListRepository
    {
        private readonly Getit _getit;

        private List<string> _pageInfo = new List<string>
            {"total", "perPage", "currentPage", "lastPage", "hasNextPage"};

        private List<string> _title = new List<string> {"romaji", "english", "native"};

        public AniListRepository()
        {
            Config config = new Config("https://graphql.anilist.co");
            _getit = new Getit(config);
        }

        public Task<AniListUser> GetUser()
        {
            throw new System.NotImplementedException();
        }

        public async Task<AniListMedia> GetMediaById(int id)
        {
            IQuery query = _getit.Query();
            IQuery title = _getit.Query();

            title.Name("title").Select("romaji", "english", "native");
            query.Name("Media").Select("id").Select(title).Where("id", id);
            var json = await _getit.Get<string>(query);
            return JsonUtils.Deserialize<AniListMedia>(json, true);
        }

        public async Task<List<AniListMedia>> GetMediasByName(string name, int page, int perPage)
        {
            IQuery query = _getit.Query();
            IQuery title = _getit.Query();
            IQuery pageInfo = _getit.Query();
            IQuery mediaQuery = _getit.Query();

            pageInfo.Name("pageInfo").Select(_pageInfo);
            title.Name("title").Select(_title);
            mediaQuery.Name("media").Where("search", name).Select("id").Select(title);
            query.Name("Page").Where("page", page).Where("perPage", perPage).Select(pageInfo).Select(mediaQuery);


            var json = await _getit.Get<string>(query);
            var aniListPage = JsonUtils.Deserialize<AniListPage>(json, true);

            return aniListPage.Media ?? new List<AniListMedia>();
        }
    }
}