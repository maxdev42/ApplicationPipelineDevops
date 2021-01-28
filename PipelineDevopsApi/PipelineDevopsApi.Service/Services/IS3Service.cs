using System.Threading.Tasks;

namespace PipelineDevopsApi.Service.Services
{
    public interface IS3Service
    {

        Task UploadFile(string bucketName);
    }
}