using System;
using System.Runtime.Serialization;

namespace ProducerService.Models
{
    [DataContract]
    public class TaxModel
    {
        [DataMember]
        public string Municipality { get; set; }
        [DataMember]
        public DateTime PeriodStart { get; set; }
        [DataMember]
        public DateTime PeriodEnd { get; set; }
        [DataMember]
        public decimal Tax { get; set; }
    }
}