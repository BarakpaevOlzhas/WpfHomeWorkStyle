using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{

    public class Earthquake
    {
        [JsonProperty("metadata")]
        public Metadata Metadata { get; set; }

        [JsonProperty("features")]
        public IList<Feature> Features { get; set; }        
    }


}
