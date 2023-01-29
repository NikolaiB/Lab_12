using Ex1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace Ex1.Controllers
{
    public class BaseDataController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        public BaseDataController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult OutputData()
        {
            var model = new OutputData();
            model.name = "Nik";
            model.date = DateTime.Now.ToString();
            model.applicationName = _webHostEnvironment.ApplicationName;
            model.environmentName = _webHostEnvironment.EnvironmentName;
            model.host = HttpContext.Request.Host.Value;
            model.protocol = HttpContext.Request.Protocol;
            return View(model);
        }

        //public IActionResult SecondTask()
        //{
        //    var obj = new ObjectController();
        //    var jsonOptions = new JsonSerializerOptions
        //    {
        //        PropertyNameCaseInsensitive = true,
        //        WriteIndented = true
        //    };
        //    ViewBag.json = JsonSerializer.Serialize(obj, jsonOptions);
        //    return View();
        //}
    }
}
