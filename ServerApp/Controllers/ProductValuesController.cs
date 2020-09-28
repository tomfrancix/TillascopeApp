using Microsoft.AspNetCore.Mvc;
using ServerApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.JsonPatch;
using System.Text.Json;
using System.Reflection;
using System.ComponentModel;
using ServerApp.Models.BindingTargets;

namespace ServerApp.Controllers {

    [Route("api/products")]
    [ApiController]
    public class ProductValuesController : Controller {
        private DataContext context;

        public ProductValuesController(DataContext ctx) {
            context = ctx;
        }

        [HttpGet("{id}")]
        public Product GetProduct(long id) {      
            Product result = context.Products
                .Include(p => p.Blueprint).ThenInclude(s => s.Products)
                .Include(p => p.Ratings)
                .FirstOrDefault(p => p.ProductId == id);


            if (result != null) {
                if (result.Blueprint != null) {
                    result.Blueprint.Products = result.Blueprint.Products.Select(p =>
                        new Product {
                            ProductId = p.ProductId,
                            Subcategory = p.Subcategory,
                            Category = p.Category,
                            Description = p.Description,
                            ImageIcon = p.ImageIcon,
                            Price = p.Price,
                        });
                }

                if (result.Ratings != null) {
                    foreach (Rating r in result.Ratings) {
                        r.Product = null;
                    }
                } 
            }
            return result;
        }

        [HttpGet]
        public IActionResult GetProducts(string subcategory, string search, 
                bool related = false, bool metadata = false) {
            IQueryable<Product> query = context.Products;

            if (!string.IsNullOrWhiteSpace(subcategory)) {
                string catLower = subcategory.ToLower();
                query = query.Where(p => p.Subcategory.ToLower().Contains(catLower));
            }
            if (!string.IsNullOrWhiteSpace(search)) {
                string searchLower = search.ToLower();
                query = query.Where(p => p.Category.ToLower().Contains(searchLower)
                    || p.Description.ToLower().Contains(searchLower));
            }

            if (related) {
                query = query.Include(p => p.Blueprint).Include(p => p.Ratings);
                List<Product> data = query.ToList();
                data.ForEach(p => {
                    if (p.Blueprint != null) {
                        p.Blueprint.Products = null;
                    }
                    if (p.Ratings != null) {
                        p.Ratings.ForEach(r => r.Product = null);
                    }
                });
                return metadata ? CreateMetadata(data) : Ok(data);
            } else {
                return metadata ? CreateMetadata(query) : Ok(query);
            }
        }

        private IActionResult CreateMetadata(IEnumerable<Product> products)
        {
            return Ok(new
            {
                data = products,
                subcategories = context.Products.Select(p => p.Subcategory)
                    .Distinct().OrderBy(c => c)
            });
        }

        [HttpPost]
        public IActionResult CreateProduct([FromBody] ProductData pdata)
        {
            if (ModelState.IsValid)
            {
                Product p = pdata.Product;
                if (p.Blueprint != null && p.Blueprint.BlueprintId != 0)
                {
                    context.Attach(p.Blueprint);
                }
                context.Add(p);
                context.SaveChanges();
                return Ok(p.ProductId);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        [HttpPut("{id}")]
        public IActionResult ReplaceProduct(long id, [FromBody] ProductData pdata)
        {
            if(ModelState.IsValid)
            {
                Product p = pdata.Product;
                p.ProductId = id;
                if (p.Blueprint != null && p.Blueprint.BlueprintId != 0)
                {
                    context.Attach(p.Blueprint);
                }
                context.Update(p);
                context.SaveChanges();
                return Ok();
            } else
            {
                return BadRequest(ModelState);
            }
        }

        [HttpPatch("{id}")]
        public IActionResult UpdateProduct(long id, [FromBody]JsonPatchDocument<ProductData> patch)
        {
            Product product = context.Products.Include(p => p.Blueprint).First(p => p.ProductId == id);

            ProductData pdata = new ProductData { Product = product };

            patch.ApplyTo(pdata, ModelState);

            if (ModelState.IsValid && TryValidateModel(pdata))
            {

                if (product.Blueprint != null && product.Blueprint.BlueprintId != 0)
                {
                    context.Attach(product.Blueprint);
                }
                context.SaveChanges();
                return Ok();
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        [HttpDelete("{id}")]
        public void DeleteProduct(long id)
        {
            context.Products.Remove(new Product { ProductId = id });
            context.SaveChanges();
        }
    }
}
