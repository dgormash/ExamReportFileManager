using System.Collections.Generic;

namespace ExamReportFileManager.Interfaces
{
    public interface IFileReader
    {
        string FilePath { get; set; }
        string ErrorMessage { get; set; }
        IEnumerable<string> ReadFile();
    }
}