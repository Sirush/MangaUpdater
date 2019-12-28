using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MangaUpdater.Domain.Common;

namespace MangaUpdater.Context
{
    public class ConfigurationContext
    {
        public static DataProvider CurrentDataProvider { get; set; } = DataProvider.AniList;
    }
}
