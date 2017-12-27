using System.IO;

namespace ProducerService.DataManagers
{
    public interface IFileManager
    {
        string GetTextFromFileByteStream(Stream fileByteStream);
    }
}
