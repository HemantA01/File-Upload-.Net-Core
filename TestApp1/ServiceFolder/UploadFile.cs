using System.Reflection.Metadata.Ecma335;
using TestApp1.Model;

namespace TestApp1.ServiceFolder
{
    public class UploadFile : IUploadFile
    {
        private readonly ApplicationContext _context;
        private IWebHostEnvironment _filpath;
        public UploadFile(ApplicationContext context, IWebHostEnvironment filpath)
        {
            _context = context;
            _filpath = filpath;
        }
        public async Task<bool> UploadFileAsync(IFormFile formFile)
        {
            bool isSuccess = false;
            int result;
            try
            {
                if (formFile != null)
                {
                    var extension = "." + formFile.FileName.Split('.')[1];
                    var pathBuild = Path.Combine(_filpath.WebRootPath, "Uploads");
                    if (!Directory.Exists(pathBuild))
                    {
                        Directory.CreateDirectory(pathBuild);
                    }
                    var path = Path.Combine(pathBuild, formFile.FileName);
                    TblFileUpload objFile = new();
                    objFile.FilePath = path;
                    objFile.FileName = formFile.FileName;
                    objFile.IsDeleted = false;
                    objFile.FileExtension = extension;
                    _context.tblFiles.Add(objFile);
                    await _context.SaveChangesAsync();
                    isSuccess = true;
                }
                return isSuccess;
            }

            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
