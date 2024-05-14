using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class data
{
    [JsonProperty("score")]
    public int score { get; set; }

    [JsonProperty("setup")]
    public string setup { get; set; }

    [JsonProperty("punchline")]
    public string punchline { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

}

}
