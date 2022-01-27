using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Interfaces;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    public class ProductsController : BaseController
    {
        private readonly IProductRepository _repo;
        public ProductsController( IProductRepository repo)
        {
            _repo = repo;
           
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            var product = await _repo.GetProductsAsync();
            return Ok(product);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct( int id)
        {
            return await _repo.GetProductByIdAsync(id);
        }
    }
}