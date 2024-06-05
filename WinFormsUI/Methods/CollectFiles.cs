using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsUI.CustomClasses;

namespace WinFormsUI.Methods
{
    public class CollectFiles
    {
        private string FilePath;
        public CollectFiles(string path)
        {
            FilePath = path;
        }

        public List<FileData> Execute()
        {
            List<FileData> files = new List<FileData>();
            List<string> filesInDir = Directory.EnumerateFiles(FilePath).ToList();

            foreach (string file in filesInDir)
            {
                FileData fd = new FileData()
                {
                    FileName = Path.GetFileName(file),
                    FilePath = FilePath,
                    HasBeenSent = false
                };

                files.Add(fd);
            }

            return files;
        }
    }
}
