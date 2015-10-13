using System.Web.Mvc;
using Spark;
using Spark.Web.Mvc;

namespace ChristianArticles.Web
{
    internal static class SparkConfig
    {
        public static void RegisterViewEngine(ViewEngineCollection engines)
        {
            var settings = new SparkSettings();
            settings.SetDebug(true);
            engines.Add(new SparkViewFactory(settings));
        }
    }
}