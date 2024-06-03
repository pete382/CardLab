using Newtonsoft.Json;
using System.Net;

namespace CardLab.Models
{
    public class ShuffleDAL
    
        
    {  public static ShuffleModel GetShuffle()
        {
            string url = "https://deckofcardsapi.com/api/deck/spdsa2ie2j2w/shuffle/";

            //request
            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //JSON
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string JSON = reader.ReadToEnd();

            //adjust
            //Convert to c#
            //Install Newtonsoft.json
            ShuffleModel result = JsonConvert.DeserializeObject<ShuffleModel>(JSON);
            return (result);

        }

    }
}
