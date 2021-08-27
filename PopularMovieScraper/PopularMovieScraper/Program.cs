using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using HtmlAgilityPack;
using System.IO;
using System.Globalization;

namespace PopularMovieScraper
{
    class Program
    {
        static void Main(string[] args)
        {
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load("https://www.imdb.com/chart/moviemeter/?ref_=nv_mv_mpm");

            string HeaderNames = doc.DocumentNode.SelectNodes("//td[@class='titleColumn']");

            var titles = new List<Row>();
            foreach (var item in HeaderNames)
                {
                    titles.Add(new Row { Title = item.InnerText});
                }
            using (var writer = new StreamWriter("Desktop/imdb_example.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteRecords(titles);
                }
        }
    }

    public class Row 
    {
        public string Title {get; set;}
    }
}
