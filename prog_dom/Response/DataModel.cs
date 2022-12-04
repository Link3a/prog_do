﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace prog_dom.Response
{
    public class DataModel
    {
        [JsonProperty(PropertyName = "temp")]
        public int Temp { get; set; }
        [JsonProperty(PropertyName = "feels_like")]
        public int FeelsLike { get; set; }
    }
}
