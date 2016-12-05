using Homework_1.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

namespace Homework_1.BussinessLogic
{
    public class InformationRetrieval
    {
        private string City;
        private string IP;
        private int Degrees_C;
        private string PhotoURL;

        private string locationString;

        public InformationRetrieval()
        {
            GetLocationJSON();
            GetWeatherJSON();
            GetPhoto();
        }

        private void GetWeatherJSON()
        {
            string json;
            string url_p1 = "https://query.yahooapis.com/v1/public/yql?q=select%20item.condition.temp%20from%20weather.forecast%20where%20woeid%20in%20(select%20woeid%20from%20geo.places(1)%20where%20text%3D%22";
            string url_p2 =     locationString + "% 22)&format = json & env = store % 3A % 2F % 2Fdatatables.org % 2Falltableswithkeys";
            string url = url_p1 + url_p2;
            url = url.Replace(" ", "");

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                json = reader.ReadToEnd();
            }

            //string values = JsonConvert.DeserializeObject<string>(json);

            var temp = json.Split(new string[] { "\"temp\":" }, StringSplitOptions.None)[1];
            string chars = string .Empty;
            int number = 0;
            
            for (int i = 0; i < temp.Length; i++)
            {
                int res = 0;
                if (int.TryParse(temp[i].ToString(), out res))
                {
                    number = number * 10 + res;
                }
            }

            Degrees_C = F_to_C(number);
        }

        private int F_to_C(int F)
        {
            int C = 0;
            C = (int)((F - 32.0) * (5.0 / 9.0));
            return C;
        }

        private void GetLocationJSON()
        {
            string json;
            string url = "http://ip-api.com/json";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                json = reader.ReadToEnd();
            }

            Dictionary<string, string> values = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);

            locationString = values["city"];

            City = locationString;
        }

        public string GetLocationString()
        {
            return locationString + " " + Degrees_C;
        }

        public void GetPhoto()
        {
            string json = string.Empty;
            string key = "041e0e51ba0f4ceb44a8978ab93f3f04";
            string url = "https://api.flickr.com/services/rest/?method=flickr.photos.search&api_key=" + key + "&tags=" + "clouds" + "&format=json";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                json = reader.ReadToEnd();
            }

            json =  json.Replace("jsonFlickrApi(", "");
            json = json.Replace(")", "");

            Container photo = JsonConvert.DeserializeObject<Container>(json);

            int r = (new Random()).Next(0, photo.photos.photo.Length - 1);

            PhotoURL = "https://farm" + photo.photos.photo[r].farm + ".staticflickr.com/" + photo.photos.photo[r].server + "/" + 
                                        photo.photos.photo[r].id  + "_" + photo.photos.photo[r].secret + " .jpg";
        }




        public int GetDegreesCelcius()
        {
            return Degrees_C;
        }

        public string GetCity()
        {
            return City;
        }

        public string GetPhotoUrl()
        {
            return PhotoURL;
        }
    }

    struct Container
    {
        public Photos photos;
    }

}