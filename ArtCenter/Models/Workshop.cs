using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtCenter.Models
{
  public class Workshop
  {


    [JsonProperty("name")]
    public string Title { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }


    public TimeSpan VideoLength { get; set; }

    [JsonProperty("created_by")]
    public string VideoProducer { get; set; }

    [JsonProperty("video_url")]
    public string VideoPath { get; set; }

    [JsonProperty("cropped")]
    public string ImagePath { get; set; }

    [JsonProperty("thumbnail")]
    public string ThumbnailPath { get; set; }
    [JsonProperty("category")]
    public string Category { get; set; }

    [JsonProperty("popularity")]
    public int Popularity { get; set; }




  }
}
