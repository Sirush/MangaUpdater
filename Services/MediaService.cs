using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MangaUpdater.Context;
using MangaUpdater.Domain.Common;
using MangaUpdater.Repositories;

namespace MangaUpdater.Services
{
    public class MediaService : IMediaService
    {
        private readonly IAniListRepository _aniListRepository;

        public MediaService(IAniListRepository aniListRepository)
        {
            _aniListRepository = aniListRepository;
        }

        public async Task<Media> GetMediaById(int id)
        {
            switch (ConfigurationContext.CurrentDataProvider)
            {
                case DataProvider.AniList:
                    var media = (await _aniListRepository.GetMediaById(id)).ToMedia();
                    return media;
            }

            return new Media();
        }

        public async Task<List<Media>> GetMediasByName(string name)
        {
            switch (ConfigurationContext.CurrentDataProvider)
            {
                case DataProvider.AniList:
                    var aniListMedias = (await _aniListRepository.GetMediasByName(name, 1, 10));
                    var medias  = new List<Media>();

                    foreach (var media in aniListMedias)
                    {
                        medias.Add(media.ToMedia());
                    }

                    return medias;
            }

            return new List<Media>();
        }
    }
}