using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QNote
{
    public static class QTool
    {
        public static string RemoveFileNameExtention(string fileName) => fileName.Substring(0, fileName.IndexOf('.'));
        
        //public static string FileNameFromPath(string path) => path.Substring(path.LastIndexOf(Get.Slash()) + 1);
        
        public static string FileExention(string file) => file.Substring(file.LastIndexOf(".") + 1);

    }
}
