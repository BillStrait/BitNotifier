using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BLNotifications.Models
{
    [DataContract]
    class MtGoxResponse
    {
        public string result { get; set; }
        public Resp @return { get; set; }
    }
    
    [DataContract]
    class Resp
    {
        public HLA high { get; set; }
        public HLA low { get; set; }
        public HLA avg { get; set; }
        public HLA vwap { get; set; }
        public HLA vol { get; set; }
        public HLA last_all { get; set; }
        public HLA last_local { get; set; }
        public HLA last_orig { get; set; }
        public HLA last { get; set; }
        public HLA buy { get; set; }
        public HLA sell { get; set; }
    }

    [DataContract]
    class HLA
    {
        public decimal value { get; set; }
        public long value_int { get; set; }
        public string display { get; set; }
        public string currency { get; set; }
    }

}
