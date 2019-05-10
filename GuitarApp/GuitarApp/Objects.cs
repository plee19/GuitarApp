using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuitarApp
{
    public class Objects
    {
        [JsonProperty("code")]
        public string Code { get; set; }
        [JsonProperty("image_url")]
        public string Image_Url { get; set; }
        [JsonProperty("instrument")]
        public Instrument Instrument { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("uri")]
        public string Uri { get; set; }
    }
}
