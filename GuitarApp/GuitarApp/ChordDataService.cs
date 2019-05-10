using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GuitarApp
{
    public class ChordDataService : IChordDataService
    {
        const string _API_KEY = "2e888ff231f21debca7a5bb9b66ab3bd3b2accd5";

        public async Task<RootObject> GetChord(string ChordName)
        {
            var url =
                $@"http://api.guitarparty.com/v2/chords/?query={ChordName}";

            var client = new HttpClient();
            using (var requestMessage = new HttpRequestMessage(HttpMethod.Get, url))
            {
                requestMessage.Headers.Add("guitarparty-api-key", "2e888ff231f21debca7a5bb9b66ab3bd3b2accd5");
                var response = await client.SendAsync(requestMessage);
                var responseObject = await response.Content.ReadAsStringAsync();
                Debug.WriteLine("responseObject: " + responseObject);
                return await Task.Factory.StartNew(() => JsonConvert.DeserializeObject<RootObject>(responseObject));
            }
            
            

            

            
        }
    }
}
