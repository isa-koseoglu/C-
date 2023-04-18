using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FolderCopyCreated.Classes
{
    public class FolderTaskService : IFolderTask
    {
        public  Task<bool> FileCopy(string localPath, string sendPath)
        {
            try
            {

                bool fileapath = System.IO.File.Exists(sendPath);
                if (fileapath) System.IO.File.Delete(sendPath);
                string fileName = System.IO.Path.GetFileName(localPath);
                string targetFilePath = System.IO.Path.Combine(sendPath, fileName);
                System.IO.File.Copy(localPath, targetFilePath, true);
                 Thread.Sleep(1000);
                return Task.FromResult(true);
            }
            catch (Exception)
            {

                return Task.FromResult(false) ;
            }

            
        }

        public IEnumerable<string> GetFile(string localPath)
        {
            if(string.IsNullOrEmpty(localPath)) return Enumerable.Empty<string>();
            if(!System.IO.Directory.Exists(localPath)) return Enumerable.Empty<string>();

            List<string> files = new List<string>();
            string[] fileNames=System.IO.Directory.GetFiles(localPath);
            foreach (string fileName in fileNames)
            {
                files.Add(fileName);
            }
            return files;

        }
    }
}
