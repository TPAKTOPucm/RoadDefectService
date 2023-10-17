using Microsoft.AspNetCore.Mvc;
using RoadDefectService.Models;
using RoadDefectService.Services;

namespace RoadDefectService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {

        private readonly ILogger<HomeController> _logger;
        private readonly IRoadService _service;

        public HomeController(ILogger<HomeController> logger, IRoadService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.GetDefects());
        }

        [HttpPost]
        public IActionResult Post(Image image)
        {
            return Ok(_service.PostPhoto(image));
        }

        [HttpPut]
        public IActionResult Put(Defects defects)
        {
            _service.SetDefect(defects);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(int x, int y)
        {
            return Ok(_service.RemoveDefect(x, y));
        }
    }
}