using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seagull.Services
{
    public class SystemConfig
    {
        public static string GetTempPath()
        {
            var dir = Directory.GetCurrentDirectory();
            var tempPath = Path.Combine(dir, "temp");
            if (!Directory.Exists(tempPath))
                Directory.CreateDirectory(tempPath);
            return tempPath;
        }
    }
}
