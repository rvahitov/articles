using System;

namespace ChristianArticles.Web.Models
{
    [Serializable]
    public class ArticlePart
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
    }
}