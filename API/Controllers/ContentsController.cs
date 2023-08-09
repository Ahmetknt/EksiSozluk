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
    public class ContentsController : ControllerBase
    {
        IContentService _contentService;

        public ContentsController(IContentService contentService)
        {
            _contentService = contentService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _contentService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);

        }

        [HttpGet("getcontentdetails")]
        public IActionResult GetContentDetails()
        {
            var result = _contentService.GetContentDetails();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);

        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _contentService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpPost("add")]
        public IActionResult Add(Content content)
        {
            var result = _contentService.Add(content);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpPost("delete")]
        public IActionResult Delete(Content content)
        {
            var result = _contentService.Delete(content);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }




    }
}
