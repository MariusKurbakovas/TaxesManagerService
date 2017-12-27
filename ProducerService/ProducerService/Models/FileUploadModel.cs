using System.IO;
using System.ServiceModel;

namespace ProducerService.Models
{
    [MessageContract]
    public class FileUploadModel
    {
        [MessageBodyMember(Order = 1)]
        public Stream FileByteStream;
    }
}