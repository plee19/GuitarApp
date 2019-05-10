using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuitarApp
{
    public class RootObject
    {
        [JsonProperty("objects")]
        public List<Objects> Objects { get; set; }
        [JsonProperty("objects_count")]
        public int Objects_Count { get; set; }
    }
}
