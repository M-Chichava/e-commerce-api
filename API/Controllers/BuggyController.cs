using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Errors;
using Microsoft.AspNetCore.Mvc;
using Persistence;

namespace API.Controllers
{
    public class BuggyController : BaseController
    {
        private readonly DataContext _context;
        public BuggyController(DataContext context)
        {
            _context = context;
            
        }

        [HttpGet("servererror")]   
        public ActionResult GetServerError()
        {
            var thing = _context.Products.Find(42);
            var thingToReturn = thing.ToString();
            
            return Ok();
        }
        
        [HttpGet("badrequest")]   
        public ActionResult GetBadRequest()
        {
            return BadRequest(new ApiResponse(400));
        } 
        
        [HttpGet("badrequest/{id}")]   
        public ActionResult GetNotFoundRequest(int id)
        {
            return Ok();
        }

        [HttpGet("notfound")]   
        public ActionResult GetNotFoundRequest()
        {
            var thing = _context.Products.Find(42);
            if(thing == null)
            {
                return NotFound(new ApiResponse(404));
            }
            return Ok();
        }
    }
}