using Amazon;
using Amazon.S3;
using Amazon.S3.Model;
using System;
using System.IO;
using System.Threading.Tasks;

namespace NetCore.FileSystem.S3
{
    public class DownloadFileS3
    {
        private const string bucketName = "test-app-devops";

        private static readonly RegionEndpoint bucketRegion = RegionEndpoint.EUWest3;
        private static IAmazonS3 client;

        public static async Task DownloadFileFromS3(string fileName)
        {

            client = new AmazonS3Client("AKIA2Y2AUVDHU2RLHMQ7", "GMoqEzgz7Mgp5GE6VS5Wx0budMPmsBiYqCmumv1T", bucketRegion);

            string responseBody = "";

            try
            {
                GetObjectRequest request = new GetObjectRequest
                {
                    BucketName = bucketName,
                    Key = fileName,
                };
                using (GetObjectResponse response = await client.GetObjectAsync(request))
                using (Stream responseStream = response.ResponseStream)
                using (StreamReader reader = new StreamReader(responseStream))
                {
                    string title = response.Metadata["x-amz-meta-title"];
                    string contentType = response.Headers["Content-Type"];
                    Console.WriteLine("Object metadata, Title: {0}", title);
                    Console.WriteLine("Content type: {0}", contentType);

                    responseBody = reader.ReadToEnd();
                }

                var pathAndFileName = @$"C:\Users\maxde\cmder\Desktop\test\{fileName}";
                var createText = responseBody;
                File.WriteAllText(pathAndFileName, createText);
            }
            catch (AmazonS3Exception e)
            {
                Console.WriteLine("Error encountered ***. Message:'{0}' when reading object", e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unknown encountered on server. Message:'{0}' when reading object", e.Message);
            }
        }
    }
}