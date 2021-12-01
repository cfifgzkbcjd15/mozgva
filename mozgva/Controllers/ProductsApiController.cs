using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using mozgva.Data;
using mozgva.Models;
using mozgva.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mozgva.Controllers
{
    public class ProductApi
    {
        public List<Product> Product { get; set; }
    }
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsApiController : ControllerBase
    {
        private readonly ApplicationContext db;
        public ProductsApiController(ApplicationContext context)
        {
            db = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> Get()
        {
            return await db.Products.ToListAsync();
        }
    }
}
