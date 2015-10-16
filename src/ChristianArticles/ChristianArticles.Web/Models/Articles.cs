using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace ChristianArticles.Web.Models
{
    [Serializable,XmlRoot]
    public class Articles
    {
        [XmlArray("Article")]
        public List<ArticleInfo> Items { get; set; }
    }
}