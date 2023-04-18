using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderCopyCreated.Classes
{
    public interface IFolderTask
    {
        public Task<bool> FileCopy(string localPath, string sendPath);

        public IEnumerable<string> GetFile(string localPath);
    }
}
