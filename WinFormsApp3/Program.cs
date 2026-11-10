using System.Xml.Serialization;

namespace WinFormsApp3;

static class Program
{
    public static string FilePath = $@"{Environment.CurrentDirectory}\Students.xml";
    
    public static FileHelper<List<Student>> FileHelper = new FileHelper<List<Student>>(Program.FilePath);
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.Run(new Form1());
    }
}