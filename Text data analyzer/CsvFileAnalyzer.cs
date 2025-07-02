using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_data_analyzer
{
    public class CsvFileAnalyzer :FileAnalyzer, IfileAnalyzer
    {
        public void AnalysisFile(FileInfo fileInfo)
        {
           
            //taking oblect from the fileinfo to use the method
            string[] FileData = File.ReadAllLines(fileInfo.FullName);//puting the data into string
            AnalysisResult result = new AnalysisResult();
            var numberOfColumn=FileData[0].Split(',');//number of rows
            if (FileData.Length == 0 || string.IsNullOrWhiteSpace(FileData[0]))
            {
                result.FieldCount = 0;
            }
            else
            {
                 numberOfColumn = FileData[0].Split(',');
                result.FieldCount = numberOfColumn.Length;
            }
            result.FieldCount = numberOfColumn.Length;
            setResult(result);
        }
    }
}
