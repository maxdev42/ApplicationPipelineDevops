using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace NetCore.FileSystem.S3
{
    public interface IFile
    {
        Stream Read(string filePath);
        FileStream ReadFileStream(string filePath);
        IEnumerable<string> ReadLines(string filePath);
        IEnumerable<string> ReadLines(string filePath, Encoding encoding);
        Task Write(Stream data, string filePath);
        Task WriteAllText(string data, string filePath);
        Task WriteAllText(string data, string filePath, Encoding encoding);
        Task Copy(string sourceFilePath, string targetFilePath);
        Task Move(string sourceFilePath, string targetFilePath);
        void Delete(string filePath);
        bool Exists(string filePath);
        string GetFileName(string filePath);
        string PathCombine(params string[] paths);
        Task AppendText(string data, string filePath);
        Task AppendText(string data, string filePath, Encoding encoding);
        Task<Stream> GetStream(string filePath);
    }
}
