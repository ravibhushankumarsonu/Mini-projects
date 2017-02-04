using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using HtmlAgilityPack;
using System.Threading.Tasks;


namespace FebWeb.WebForms
{
    public class NameAndScore
    {
        public string Name { get; set; }
        public string Score { get; set; }
    }
    public partial class WebForm1 : System.Web.UI.Page
    {
        DataTable tabel;
        HtmlWeb web = new HtmlWeb();
        public void InitTable()
        {
            tabel = new DataTable();
            tabel.Columns.Add("Name", typeof(string));
            tabel.Columns.Add("Score", typeof(string));
            tabel.Rows.Add("Super Mario 64", "64%");
        }

        private async Task<List<NameAndScore>> GetRankingFromPage(int pageNumber)
        {
            string url = "http://www.gamerankings.com/browse.html";
            if(pageNumber!=0)
               url = "http://www.gamerankings.com/browse.html?page="+pageNumber.ToString();

            var doc = await Task.Factory.StartNew(() => web.Load(url));
            var nameNodes = doc.DocumentNode.SelectNodes("//*[@id=\"main_col\"]//div//div//table//tr//td//a");
            var ScoreNodes = doc.DocumentNode.SelectNodes("//*[@id=\"main_col\"]//div//div//table//tr//td//span/b");
            //Return if name and score nodes are null
            if (nameNodes == null || ScoreNodes == null)
                return new List<NameAndScore>();
            var names = nameNodes.Select(node => node.InnerText);
            var scores = ScoreNodes.Select(node => node.InnerText);
            return names.Zip(scores, (name, score) => new NameAndScore() { Name = name, Score = score}).ToList();
        }

        protected async void Page_Load(object sender, EventArgs e)
        {
            InitTable();
           // int pageNum = 0;
            var ranking = await GetRankingFromPage(0);
            foreach (var item in ranking)
            {
                tabel.Rows.Add(item.Name, item.Score);
            }
            //This is used to load page for infinity time 
            //while (ranking.Count>0)
            //{
            //    foreach (var item in ranking)
            //    {
            //        tabel.Rows.Add(item.Name, item.Score);
            //    }
            //    await GetRankingFromPage(++pageNum);
            //}
            GridView1.DataSource = tabel;
            GridView1.DataBind();
        }
    }
}