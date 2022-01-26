using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    public class ProductsController : BaseController
    {
        private readonly DataContext _context;
        public ProductsController( DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            var product = await _context.Products.ToListAsync();
            return Ok(product);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct( int id)
        {
            return await _context.Products.FindAsync(id);
        }
    }
}