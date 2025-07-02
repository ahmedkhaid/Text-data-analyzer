using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_data_analyzer
{
    internal class TxtFileAnalyzer : FileAnalyzer,IfileAnalyzer
    {
        public void AnalysisFile(FileInfo fileInfo)
        {
            //taking oblect from the fileinfo to use the method
            string FileData=File.ReadAllText(fileInfo.FullName);//puting the data into string
            AnalysisResult result =new AnalysisResult();
            //number of words in the file
            var words = FileData.Split(new char []{ '\n', ' ', '\r' });
            var lines = FileData.Split(new char[] { '\n' });
            //since the fileData return string and rthe string consist of carachters
            var characters = FileData.Length;
            result.WordCount = words.Length;
            result.CaracterCount = characters;
            result.LineCount = lines.Length;
            setResult(result);
            
        }
    }
}
