using System;
using System.IO;
using System.Collections.Generic;
namespace TPCleanArchi.Core
{
    public class ReadToFile
    {
        private const string filePath = @"../../db.txt";

        public ReadToFile() { }

        public string[] ReadLines()
        {
            return File.ReadAllLines(filePath);
        }
    }
}