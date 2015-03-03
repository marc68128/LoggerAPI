using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LoggerAPI.Models
{
    public class Log
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        [JsonProperty(PropertyName = "app_name")]
        public string AppName { get; set; }

        [JsonProperty(PropertyName = "phone_id")]
        public string PhoneId { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "level")]
        public int Level { get; set; }

        [JsonProperty(PropertyName = "stack_trace")]
        public string StackTrace { get; set; }

        public string Class
        {
            get
            {
                switch (Level)
                {
                    case 2:
                        return "info"; 
                    case 3:
                        return "warning"; 
                    case 4 :
                        return "danger";
                }
                return ""; 
            }
        }
    }
}
