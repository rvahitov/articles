using System;
using System.Collections.Generic;

namespace ChristianArticles.Web.Models
{
    [Serializable]
    
    public class ArticleInfo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Controller { get; set; }
        public List<string> Authors { get; set; }
        public string Description { get; set; }
        public List<ArticlePart> Parts { get; set; }
        public bool SingleParted { get; set; }
    }
}