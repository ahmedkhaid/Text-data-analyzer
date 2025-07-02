using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
namespace Text_data_analyzer
{
    
    public interface IfileAnalyzer
    {
        public void AnalysisFile(FileInfo fileInfo);
       
    }
}
