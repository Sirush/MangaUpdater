using System.Linq;
using Newtonsoft.Json.Linq;

namespace MangaUpdater.Utils
{
    public static class JsonUtils
    {
        public static T Deserialize<T>(string json, bool ignoreRoot) where T : class
        {
            return ignoreRoot
                ? JObject.Parse(json)?.Properties()?.First()?.Value?.ToObject<T>()
                : JObject.Parse(json)?.ToObject<T>();
        }
    }
}