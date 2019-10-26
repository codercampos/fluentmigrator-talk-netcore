using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sample.API.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sample.API.Controllers
{
    [Route("api/[controller]")]
    public class BlogPostsController : Controller
    {
        private readonly ApplicationContext _context;

        public BlogPostsController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<BlogPost> Get()
        {
            return _context.BlogPosts.ToList();
        }
    }
}
