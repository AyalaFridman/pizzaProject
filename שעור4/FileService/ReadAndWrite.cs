using System.IO;
using System.Text.Json;

namespace FileService;
public class ReadAndWrite:IFileService
{
    public string filePath { get; set; }
    
    public ReadAndWrite()
    {
        this.filePath = Path.Combine(Environment.CurrentDirectory, "File", "readWrite.txt");
    }
    
    public void WriteMessage(string message)
    {
        if (File.Exists(this.filePath))
        {
            File.AppendAllText(filePath ,$"{DateTime.Now}: {message}");
        }
    }

}