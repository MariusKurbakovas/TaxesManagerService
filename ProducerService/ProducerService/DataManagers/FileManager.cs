using System.IO;

namespace ProducerService.DataManagers
{
    public class FileManager : IFileManager
    {
        public string GetTextFromFileByteStream(Stream fileByteStream)
        {
            StreamReader reader = null;
            try
            {
                reader = new StreamReader(fileByteStream);
                string text = reader.ReadToEnd();
                return text;
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
                if (fileByteStream != null)
                {
                    fileByteStream.Close();
                }
            }
        }
    }
}