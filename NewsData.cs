using System;
using System.Collections.Generic;

namespace CA3_BlazorApp
{


        public class Source
    {
        
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Article
    {
        public Source source { get; set; }
        public string author { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string url { get; set; }
        public string urlToImage { get; set; }
        public DateTime publishedAt { get; set; }
        public string content { get; set; }
        

          public bool filterArticle(string filter)
        {

            if (string.IsNullOrWhiteSpace(filter))
            {

                return true;

            }

            if (source.name.Equals(filter))
            {
                return true;
            }

            return false;

        }

    }

    public class Root
    {
        public string status { get; set; }
        public int totalResults { get; set; }
        public List<Article> articles { get; set; }
    }



}
