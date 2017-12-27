using System.IO;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace ProducerService.Models
{
    [MessageContract]
    public class FileUploadModel : IExtensibleDataObject
    {
        [MessageBodyMember(Order = 1)]
        public Stream FileByteStream;

        private ExtensionDataObject theData;

        public virtual ExtensionDataObject ExtensionData
        {
            get { return theData; }
            set { theData = value; }
        }
    }
}