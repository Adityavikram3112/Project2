using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class WeatherProcessor
    {
        static List<double> Info = new List<double>();
        static List<double> WindInfo = new List<double>();
        static WeatherData.root Details = new WeatherData.root();
        public List<double> WheatherInfo(string city)//async Task<Wheatherdata.root>
        {
            //string url = $"q=mumbai&appid=3c4b8e2bbf7e42b8d1cfe1dcfab53fa5";
            string apirequest = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid=3c4b8e2bbf7e42b8d1cfe1dcfab53fa5";// here change the api id according to the one you get 
            var Info = new List<double>();
            var WindInfo = new List<double>();
            var Details = new WeatherData.root();


            using (WebClient web = new WebClient())
            {
                var json = web.DownloadString(apirequest);
                Details = JsonConvert.DeserializeObject<WeatherData.root>(json);

                Info.Add(Details.main.temp_max);
                Info.Add(Details.main.temp_min);
                Info.Add(Details.wind.speed);
            }
            return Info;

        }
    }
}
