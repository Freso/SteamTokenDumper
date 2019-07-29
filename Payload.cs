﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SteamTokenDumper
{
    internal sealed class Payload
    {
        [JsonProperty("v")]
        public const uint Version = 10;

        [JsonProperty("steamid")]
        public ulong SteamID;

        [JsonProperty("apps")]
        public Dictionary<uint, string> Apps = new Dictionary<uint, string>();

        [JsonProperty("depots")]
        public Dictionary<uint, string> Depots = new Dictionary<uint, string>();
    }
}