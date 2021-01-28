using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PipelineDevopsApi.Service.Services;
using System;
using TestAwsS3;

namespace PipelineDevopsApi.Service.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class TestAwsS3Controller : ControllerBase
    {
        private readonly ILogger<TestAwsS3Controller> _logger;
        private readonly IS3Service _service;

        public TestAwsS3Controller(ILogger<TestAwsS3Controller> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("GetFile")]
        public string TestAwsS3GetFile(string filename)
        {
            try
            {
                UploadFileS3.DownloadFileFromS3(filename);
                return "Process executed API POST !";
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

        //[HttpGet]
        //public async Task<ActionResult<object>> TestAwsS3PrintAllFiles()
        //{
        //    //TODO code AWS S3 part
        //}

        //[HttpGet]
        //public async Task<ActionResult<object>> TestAwsS3PrintCurrentPath()
        //{
        //    //TODO code AWS S3 part
        //}

        [HttpPost]
        [Route("TestAwsS3PostFile")]
        public string TestAwsS3PostFile(IFormFile inputFile)
        {
            try
            {
                UploadFileS3.UploadFileToS3(inputFile);
                return "Process executed API POST !";
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

    }
}
