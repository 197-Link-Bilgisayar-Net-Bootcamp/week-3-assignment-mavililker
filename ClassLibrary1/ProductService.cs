using Microsoft.EntityFrameworkCore;
using NLayerData;
using NLayerData.Models;
using NLayerService.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerService
{
    public class ProductService
    {
        private readonly AppDbContext _context;

        public ProductService(AppDbContext context)
        {
            _context = context;
        }

        

        public async Task<List<ProductDTO>> GetAll()
        {
            var products = await _context.Products.ToListAsync();

            return products.Select(p => new ProductDTO()
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price,
                CategoryId = p.CategoryId
            }).ToList();
        }
    }
}
