using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Twitch.Api.Data;
using Twitch.Api.Data.BaseEntity;

namespace Twitch.API.Data.User
{
    
    public class TwitchUser : ITwitchDataEntity
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "login")]
        public string Login { get; set; }

        [JsonProperty(PropertyName = "display_name")]
        public string DisplayName { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "broadcaster_type")]
        public string BroadcasterType { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "profile_image_url")]
        public string ProfileImageUrl { get; set; }

        [JsonProperty(PropertyName = "offline_image_url")]
        public string OfflineImageUrl { get; set; }

        [JsonProperty(PropertyName = "view_count")]
        public int ViewCount { get; set; }

        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }
    }
}
