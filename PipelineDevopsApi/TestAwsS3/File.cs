using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace NetCore.FileSystem.S3
{
    public class File : IFile
    {
        static Instantiator instantiator = new Instantiator();

        static IAmazonS3 client = instantiator.client;
        static public File file = new File();

        public async Task AppendText(string data, string filePath)
        {
            var taskExist = Task.Run(async () => await ExistAsync(filePath));
            var isExist = taskExist.Result;

            if (isExist)
            {
                var task = Task.Run(async () => await ReadAsync(filePath));
                var ms = task.Result;

                byte[] existingData = Encoding.UTF8.GetBytes(data);
                ms.Write(existingData, 0, existingData.Length);

                Write(ms, filePath);
            }
            else
            {
                WriteAllText(data, filePath);
            }
        }

        public Task AppendText(string data, string filePath, Encoding encoding)
        {
            throw new NotImplementedException();
        }

        public async Task Copy(string sourceFilePath, string targetFilePath)
        {
            CopyObjectRequest request = new CopyObjectRequest()
            {
                SourceBucket = instantiator.bucketName,
                SourceKey = sourceFilePath,
                DestinationBucket = instantiator.bucketName,
                DestinationKey = targetFilePath
            };
            CopyObjectResponse response = await client.CopyObjectAsync(request);
        }

        public void Delete(string filePath)
        {
            throw new NotImplementedException();
        }

        public bool Exists(string filePath)
        {
            throw new NotImplementedException();
        }

        public string GetFileName(string filePath)
        {
            throw new NotImplementedException();
        }

        public Task<Stream> GetStream(string filePath)
        {
            throw new NotImplementedException();
        }

        public Task Move(string sourceFilePath, string targetFilePath)
        {
            throw new NotImplementedException();
        }

        public string PathCombine(params string[] paths)
        {
            throw new NotImplementedException();
        }

        public Stream Read(string filePath)
        {
            throw new NotImplementedException();
        }

        public FileStream ReadFileStream(string filePath)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> ReadLines(string filePath)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> ReadLines(string filePath, Encoding encoding)
        {
            throw new NotImplementedException();
        }

        public async Task Write(Stream data, string filePath)
        {
            var fileTransferUtility = new TransferUtility(client);
            fileTransferUtility.Upload(data, instantiator.bucketName, filePath);
        }

        public Task WriteAllText(string data, string filePath)
        {
            throw new NotImplementedException();
        }

        public Task WriteAllText(string data, string filePath, Encoding encoding)
        {
            throw new NotImplementedException();
        }
    }
}
