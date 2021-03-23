using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NetCore.FileSystem.S3
{
    public interface IDirectory
    {
        Task<string> Create(string directoryPath);
        Task Delete(string directoryPath);
        IEnumerable<string> EnumerateFiles(string directoryPath);
        IEnumerable<string> EnumerateDirectories(string directoryPath);
        string GetDirectoryName(string directoryPath);
        bool Exists(string directoryPath);
    }
}
