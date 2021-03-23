using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Transfer;
using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Threading.Tasks;

namespace NetCore.FileSystem.S3
{
    public class UploadFileS3
    {

        public static async Task UploadFileToS3(IFormFile file)
        {
            try
            {
                var credentials = new BasicAWSCredentials("AKIA2Y2AUVDHU2RLHMQ7", "GMoqEzgz7Mgp5GE6VS5Wx0budMPmsBiYqCmumv1T");
                var config = new AmazonS3Config
                {
                    RegionEndpoint = Amazon.RegionEndpoint.EUWest3
                };
                using var client = new AmazonS3Client(credentials, config);
                await using var newMemoryStream = new MemoryStream();
                file.CopyTo(newMemoryStream);

                var uploadRequest = new TransferUtilityUploadRequest
                {
                    InputStream = newMemoryStream,
                    Key = file.FileName,
                    BucketName = "test-app-devops",
                    CannedACL = S3CannedACL.BucketOwnerFullControl
                };

                var fileTransferUtility = new TransferUtility(client);
                await fileTransferUtility.UploadAsync(uploadRequest);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }


    }
}