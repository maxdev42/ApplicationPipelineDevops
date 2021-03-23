using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NetCore.FileSystem.S3
{
    public class Directory : IDirectory
    {
        public Task<string> Create(string directoryPath)
        {
            throw new NotImplementedException();
        }

        public Task Delete(string directoryPath)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> EnumerateDirectories(string directoryPath)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> EnumerateFiles(string directoryPath)
        {
            throw new NotImplementedException();
        }

        public bool Exists(string directoryPath)
        {
            throw new NotImplementedException();
        }

        public string GetDirectoryName(string directoryPath)
        {
            throw new NotImplementedException();
        }
    }
}
