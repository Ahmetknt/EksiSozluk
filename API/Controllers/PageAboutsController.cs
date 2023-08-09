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
    public class PageAboutsController : ControllerBase
    {
        IPageAboutService _pageAboutService;

        public PageAboutsController(IPageAboutService pageAboutService)
        {
            _pageAboutService = pageAboutService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _pageAboutService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);

        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _pageAboutService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpPost("add")]
        public IActionResult Add(PageAbout pageAbout)
        {
            var result = _pageAboutService.Add(pageAbout);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpPost("delete")]
        public IActionResult Delete(PageAbout pageAbout)
        {
            var result = _pageAboutService.Delete(pageAbout);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
    }
}
