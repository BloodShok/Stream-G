using System;

namespace StreamG.DTO
{
    public class TwitchAuthorizeInfoDto
    {
        public string AccessCode { get; set; }
        public string Id { get; set; }
        public string DisplayName { get; set; }
        public string ProfileImageUrl { get; set; }
    }
}
