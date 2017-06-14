using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using ExamReportFileManager.Interfaces;
using ExamReportFileManager.Implementations;


namespace ExamReportFileManager
{
    public class ErFileManager
    {
        private IFileReader _reader;
        private IGroupReport _report;

        public void ReadFile(string filePath)
        {
            _reader = new ErFileReader
            {
                FilePath = filePath
            };

            var fileContent = _reader.ReadFile();

        }
    }
}
