using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_data_analyzer
{
    public class FileAnalyzer
    {
       private AnalysisResult _result;
        public void setResult(AnalysisResult result)
        {
            this._result = result;
        }
        public AnalysisResult getResult()
        {
            return this._result;
        }

    }
}
