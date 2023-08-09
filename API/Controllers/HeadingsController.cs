using Businees.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeadingsController : ControllerBase
    {
        IHeadingService _headingService;

        public HeadingsController(IHeadingService headingService)
        {
            _headingService = headingService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _headingService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);

        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _headingService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpPost("add")]
        public IActionResult Add(Heading heading)
        {
            var result = _headingService.Add(heading);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpPost("delete")]
        public IActionResult Delete(Heading heading)
        {
            var result = _headingService.Delete(heading);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
    }
}
