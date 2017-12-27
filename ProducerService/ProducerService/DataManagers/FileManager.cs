using System;
using System.IO;

namespace ProducerService.DataManagers
{
    public class FileManager
    {
        public string GetTextFromFileByteStream(Stream fileByteStream)
        {
            StreamReader reader = null;
            try
            {
                reader = new StreamReader(fileByteStream);
                string text = reader.ReadToEnd();
                reader.Close();
                return text;
            }
            //TODO: deal with exceptions
            catch (IOException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
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