using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seagull.Services
{
    public class MyFileHelper
    {
        public static void Write(string msg)
        {
            try
            {
                msg = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss -> ") + msg + "\n";
                var path = System.IO.Path.Combine(System.Environment.CurrentDirectory, "Log");
                if (!System.IO.Directory.Exists(path))
                    System.IO.Directory.CreateDirectory(path);
                var fileName = DateTime.Now.ToString("yyyy-MM-dd") + "_RunningLog.txt";
                var fullName = System.IO.Path.Combine(path, fileName);
                System.IO.File.AppendAllText(fullName, msg);
            }
            catch { }
        }
    }
}
