namespace TestApp1.ServiceFolder
{
    public interface IUploadFile
    {
        Task<bool> UploadFileAsync(IFormFile formFile);
    }
}
