using BeDauThau.Interface;
using BeDauThau.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BeDauThau.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MainController : ControllerBase
    {
        private readonly IMainService _IMainService;

        public MainController( IMainService mainService)
        {
            _IMainService = mainService;
        }

        [HttpPost("GetAll")]
        public async Task<List<Project>> GetAll()
        {
            var items = await _IMainService.GetAll();
            return items;
        }
        [HttpPost("GetById")]
        public async Task<Project> GetById(string id)
        {
            var items = await _IMainService.GetById( id);
            return items;
        }
        [HttpPut("Delete")]
        public async Task<IActionResult> Delete(string id)
        {
            var items = await _IMainService.Delete( id);
            return Ok(items);
        }
        [HttpPost("Create")]
        public async Task<IActionResult> Create(Project request)
        {
            var items = await _IMainService.Create(request);
            return Ok(items);
        }
    }
}
