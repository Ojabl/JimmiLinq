using System;
using System.Collections.Generic;
using System.Linq;

namespace JimmiLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<string> mostExpansiveComicDescriptions =
                from comic in Comic.Catalog
                where Comic.Prices[comic.Issue] > 500
                orderby Comic.Prices[comic.Issue] descending
                select $"{comic} is worth {Comic.Prices[comic.Issue]:c}";
        }
    }
}