using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Transfer;
using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Threading.Tasks;

namespace TestAwsS3
{
  
    public class UploadFileS3
    {

        public static async Task UploadFileToS3(IFormFile file)
        {
            try
            {
                var credentials = new BasicAWSCredentials("AKIAJUAEARELKTULQ3FQ", "eW+oN0aJpPat+N73Gxr5zac3U+6x7xlRoNoSP6JS");
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
