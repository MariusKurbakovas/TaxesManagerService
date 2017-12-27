using System.IO;
using System.ServiceModel;

namespace ProducerService.Models
{
    [MessageContract]
    public class FileUpload
    {
        [MessageBodyMember(Order = 1)]
        public Stream FileByteStream;
    }
}