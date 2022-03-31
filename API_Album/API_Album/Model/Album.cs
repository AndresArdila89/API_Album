﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace API_Album.Model
{
    class Album
    {
        [JsonProperty("albumId")]
        public int AlbumId { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("thumbnailUrl")]
        public string ThumbnailUrl { get; set; }

        public string tbUrl { get { return this.ThumbnailUrl + ".png"; } }
    }
}
