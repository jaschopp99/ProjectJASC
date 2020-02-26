using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectJASC
{
    [Serializable()]
    class ISSReading
    {
        public uint Timestamp { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
      
        public DateTime TimestampHumanReadable
        {
            get
            {
                
                DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(Timestamp);
                DateTime dateTime = dateTimeOffset.LocalDateTime;

                return dateTime;
            }


        }

    }
}
