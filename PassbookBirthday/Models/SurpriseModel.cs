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

        [JsonProperty("greeting")]
        public string Greeting { get; set; }

        [JsonProperty("signature_line_one")]
        public string SignatureLineOne { get; set; }

        [JsonProperty("signature_line_two")]
        public string signatureLineTwo { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }
    }
}
