using System;
using System.Collections.Generic;
using System.Linq;

namespace CA3_BlazorApp
{
    public class NewsQueryData 
    {
        public string filter { get; set; }
        public Root todoItems;

        public HashSet<String> SourceList()
        {
            return todoItems.articles.Select(e => e.source.name).ToHashSet();
        }

        public void SortDateByDateAscending()
        {
            todoItems.articles = todoItems.articles.OrderBy(e => e.publishedAt).ToList();
        }

        public void SortDateByDateDescending()
        {
            todoItems.articles = todoItems.articles.OrderByDescending(e => e.publishedAt).ToList();
        }

    }
}
