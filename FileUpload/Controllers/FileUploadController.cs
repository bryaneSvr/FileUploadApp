using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FileUpload.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileUploadController : ControllerBase
    {
        // POST api/<FileUploadController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }
    }
}
