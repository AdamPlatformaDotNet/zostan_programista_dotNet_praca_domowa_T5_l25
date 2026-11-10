using System.Xml.Serialization;

namespace WinFormsApp3;

public class FileHelper<T> where T : new()
{
    private string _filePath;
    private XmlSerializer _serializer = new XmlSerializer(typeof(T));

    public FileHelper(string filePath)
    {
        _filePath = filePath;
    }
    public void SerializeToFile(T students)
    {
        using (var streamWriter = new StreamWriter(_filePath))
        {
            _serializer.Serialize(streamWriter, students);
            streamWriter.Close();
        }
    }

    public T DeserializeFromFile()
    {
        if (!File.Exists(_filePath))
        {
            return new T();
        }
        using (var streamReader = new StreamReader(_filePath))
        {
            var students = (T)_serializer.Deserialize(streamReader)!;
            streamReader.Close();
            return students;
        }
    }   
}