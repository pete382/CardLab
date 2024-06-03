using System.Net;
using System;
using Newtonsoft.Json;


namespace CardLab.Models
{
    public class DrawDAL

    {   public static DrawModel GetCard()
        {
            string url = "https://deckofcardsapi.com/api/deck/spdsa2ie2j2w/draw/?count=5";

            //request
            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //JSON
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string JSON = reader.ReadToEnd();

            //adjust
            //Convert to c#
            //Install Newtonsoft.json
            DrawModel result = JsonConvert.DeserializeObject<DrawModel>(JSON);
            return (result);



        }
    }
}
