using System;
using System.IO;
using System.Collections.Generic;

namespace TPCleanArchi.Core
{
    public class WriteToFile
    {
        private const string filePath = @"../../db.txt";

        public WriteToFile() { }

        public void WriteLine(string line)
        {
            using (StreamWriter sw = File.AppendText(filePath)) sw.Write(line);
        }
    }
}