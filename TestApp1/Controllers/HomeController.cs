using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TestApp1.Models;
using TestApp1.ServiceFolder;

namespace TestApp1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUploadFile _uploadFile;
        public HomeController(ILogger<HomeController> logger, IUploadFile uploadFile)
        {
            _logger = logger;
            _uploadFile = uploadFile;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpPost]
        public async Task<JsonResult> UploadFilePage(IFormFile formFile)
        {
            var getdetails = await _uploadFile.UploadFileAsync(formFile);
            return Json(getdetails);
        }
        public IActionResult UploadFile()
        {
            return View();
        }
    }
}