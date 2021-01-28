using Amazon.S3;
using Amazon.S3.Transfer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PipelineDevopsApi.Service.Services
{    
    public class S3Service : IS3Service
    {

        private const string FilePath = "C:\\Users\\MaxDev42\\Downloads\\IAmATestingPOSTFile.txt";
        private readonly IAmazonS3 _client;

        public S3Service(IAmazonS3 client) {
            _client = client;
        }

        public async Task UploadFile(string bucketName)
        {
            try
            {
                var fileTransferUtility = new TransferUtility(_client);

                //option1
                fileTransferUtility.UploadAsync(FilePath, bucketName);

                
            }
            catch (AmazonS3Exception e) {
                Console.WriteLine("Error on server : {0}", e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error on server : {0}", e.Message);
            }
        }
    }
}
