using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuitarApp
{
    public class Instrument
    {
        [JsonProperty("name")]
        public string InstrumentName { get; set; }
        [JsonProperty("safe_name")]
        public string Safe_Name { get; set; }
        [JsonProperty("tuning")]
        public string Tuning { get; set; }
    }
}
