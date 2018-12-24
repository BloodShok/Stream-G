using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Twitch.Api.Data.BaseEntity;

namespace Twitch.API.Data.BaseEntity
{
    public class TwitchDataEntityContainer<T> where T : ITwitchDataEntity
    {
        [JsonProperty(PropertyName = "data")]
        public List<T> Entities { get; set; }
    }
}
