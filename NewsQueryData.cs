using System;
using System.Collections.Generic;
using System.Linq;

namespace CA3_BlazorApp
{
    public class NewsQueryData 
    {
        public string filter { get; set; }
        public Root newsData;

        public HashSet<String> SourceList()
        {
            return newsData.articles.Select(e => e.source.name).ToHashSet();
        }

        public void SortDateByDateAscending()
        {
            newsData.articles = newsData.articles.OrderBy(e => e.publishedAt).ToList();
        }

        public void SortDateByDateDescending()
        {
            newsData.articles = newsData.articles.OrderByDescending(e => e.publishedAt).ToList();
        }

    }
}
