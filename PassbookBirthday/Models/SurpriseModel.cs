using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PassbookBirthday.Models
{
    public class SurpriseModel
    {
        [JsonProperty("name")]
        public string RecipientName { get; set; }
    }
}
