using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MangaUpdater.Domain.Common
{
    public class Media
    {
        public int? AniListId { get; set; }
        public string? TitleRomaji { get; set; }
        public string? TitleEnglish { get; set; }
        public string? TitleNative { get; set; }
    }
}