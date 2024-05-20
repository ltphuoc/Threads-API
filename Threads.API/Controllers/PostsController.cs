using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Threads.DataTier.Models;
using Swashbuckle.AspNetCore.Annotations;
using Threads.BusinessTier;
namespace Threads.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public PostsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Posts
        [HttpGet]
        [SwaggerOperation("Get all posts information in system")]
        public IActionResult GetAllPosts()
        {
            var posts = _unitOfWork.Post.GetAll();
            return new ObjectResult(posts);
        }

    }
}
