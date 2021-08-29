using Newtonsoft.Json;
using System.IO;

namespace ProjectAD
{
    public class FileHelper<T> where T : new()
    {
        private readonly string _filePath;

        public FileHelper(string filePath)
        {
            _filePath = filePath;
        }
        public void SerializeToFile(T files)
        {
            JsonSerializer serializer = new JsonSerializer();
            serializer.NullValueHandling = NullValueHandling.Ignore;

            using (StreamWriter streamWriter = new StreamWriter(_filePath))
            using (JsonWriter writer = new JsonTextWriter(streamWriter))
            {
                serializer.Serialize(writer, files);
                writer.Close();
                streamWriter.Close();
            }
        }
        public T DeserializeFromFile()
        {

            if (!File.Exists(_filePath))
                return new T();

            using (StreamReader file = new StreamReader(_filePath))
            {
                JsonSerializer serializer = new JsonSerializer();
                T files = (T)serializer.Deserialize(file, typeof(T));
                if (files == null)
                {
                    files = new T();
                }
                return files;
            }
        }
    }
}
