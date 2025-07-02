using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_data_analyzer
{
    public static class FileInfoExtention
    {
       public static bool IsTextFille(this FileInfo fileInfo)
        {
            if(fileInfo.Extension==".txt")
                return true; 
            else
                return false;
        }
        public static bool IsCsvFille(this FileInfo fileInfo)
        {
            if (fileInfo.Extension == ".csv")
                return true;
            else
                return false;
        }
    }
}
