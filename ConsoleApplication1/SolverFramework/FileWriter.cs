using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace SolverFramework
{
    class FileWriter
    {
        // ../../ to move it to project file
        private string _path;
        public FileWriter(string fileName)
        {
            _path = fileName;
        }
        public void WriteToFile(string stringToWrite)
        {
            using (FileStream fs = new FileStream(_path, FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter writer = new StreamWriter(fs))
                {
                    writer.Write(stringToWrite);
                }
            }
        }

    }
}
