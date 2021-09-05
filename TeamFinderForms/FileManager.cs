
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TeamFinderForms
{
    static class FileManager
    {
        public static void  InsertToFile<T>(IList<T> team,string filePath)
        {
            File.Delete(filePath);
            File.WriteAllLines(filePath, (IEnumerable<string>)team);
        }

    }
}
