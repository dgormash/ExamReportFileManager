using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamReportFileManager.Interfaces;
using Microsoft.SqlServer.Server;
using System.IO;

namespace ExamReportFileManager.Implementations
{
    class ErFileReader:IFileReader
    {
        public string FilePath { get; set; }
        public string ErrorMessage { get;  set; }
        

        public IEnumerable<string> ReadFile()
        {
            IEnumerable<string> result = null;

            try
            {
               result = File.ReadLines(FilePath, Encoding.GetEncoding(1251));
            }
            catch (Exception err)
            {
                ErrorMessage = err.Message;
            }

            return result;
        }
    }
}
