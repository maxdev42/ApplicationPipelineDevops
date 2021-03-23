using Amazon;
using Amazon.S3;
using System;

namespace NetCore.FileSystem.S3
{
    public class Instantiator
    {

        public string bucketName { get; set; } = "my.bucket.name";
        public IAmazonS3 client { get; set; }

        public Instantiator()
        {
            var config = new AmazonS3Config
            {
                RegionEndpoint = RegionEndpoint.EUWest3,
                ServiceURL = "http://browser.s3"
            };

            string accessKey = Environment.GetEnvironmentVariable("S3_ACCESS_KEY");
            string secretAccessKey = Environment.GetEnvironmentVariable("S3 _SECRET_ACCESS_KEY");

            client = new AmazonS3Client(accessKey, secretAccessKey, config);
        }

    }
}
