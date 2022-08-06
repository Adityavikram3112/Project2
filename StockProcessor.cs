using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Project2
{
    class StockProcessor
    {
        static List<double> close = new List<double>();
        static StockData.root sd = new StockData.root();

        public void GetData()
        {

            //string apirequest = "https://api.apilayer.com/currency_data/change?start_date=2018-06-25&end_date=2018-06-26apikey=";
            //Uri queryUri = new Uri(apirequest);
            //using (WebClient web = new WebClient())
            //{
            //    JavaScriptSerializer js = new JavaScriptSerializer();
            //    var json = web.DownloadString(apirequest);
            //    sd = JsonConvert.DeserializeObject<StockData.root>(json);
            //    close.Add(sd.quotes.USDINR.end_rate);
            //}
            string QUERY_URL = "https://www.alphavantage.co/query?function=TIME_SERIES_DAILY&symbol=IBM&apikey=demo&datatype=csv";
            Uri queryUri = new Uri(QUERY_URL);

            using (WebClient web1 = new WebClient())
            {
                JavaScriptSerializer js = new JavaScriptSerializer();
                string temp = "myfile";
                web1.DownloadFile(queryUri, temp);
                // var jsondata = js.Deserialize(web1.DownloadString(queryUri), typeof(object));

                //var temp =(JsonReader) web1.DownloadString(queryUri);


                // close.Add(sd.quotes.USDINR.end_rate);
            }
            //return close;

            using (WebClient web2 = new WebClient())
            {
                JavaScriptSerializer js = new JavaScriptSerializer();
                string temp = "myfile";
                web2.DownloadFile(queryUri, temp);

            }
        }
    }
}
