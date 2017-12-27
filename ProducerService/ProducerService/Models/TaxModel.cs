using System;
using System.Runtime.Serialization;

namespace ProducerService.Models
{
    [DataContract]
    public class TaxModel : IExtensibleDataObject
    {
        [DataMember]
        public string Municipality { get; set; }
        [DataMember]
        public DateTime PeriodStart { get; set; }
        [DataMember]
        public DateTime PeriodEnd { get; set; }
        [DataMember]
        public decimal Tax { get; set; }

        private ExtensionDataObject theData;

        public virtual ExtensionDataObject ExtensionData
        {
            get { return theData; }
            set { theData = value; }
        }
    }
}