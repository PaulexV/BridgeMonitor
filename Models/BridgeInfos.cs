// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 

using System;
using Newtonsoft.Json;

namespace PontChaban.Models
{
    public class BridgeInfos
    {
        [JsonProperty("boat_name")]
        public string BoatName { get; set; }

        [JsonProperty("closing_type")]
        public string ClosingType { get; set; }

        [JsonProperty("closing_date")]
        public DateTime ClosingDate { get; set; }

        [JsonProperty("reopening_date")]
        public DateTime ReopeningDate { get; set; }
        public int Id { get; set; }
    }

}