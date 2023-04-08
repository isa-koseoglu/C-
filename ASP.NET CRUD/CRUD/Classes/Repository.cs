using EchoposCRUD.Context;
using EchoposCRUD.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EchoposCRUD.Classes
{
    public class Repository : IRepository<Product>
    {
        private readonly CrudContext context;
        public Repository(CrudContext _context)
        {
            context = _context;
        }
        public async Task<Product> Add(Product entity)
        {
            var result = Get(entity.ID).Result;
            if( result is  null)
            {
                
                   await context.Products.AddAsync(entity);
                   await  context.SaveChangesAsync();
                   return entity;
                
            }
            return null;
        }

        

        public async Task<Product> Get(int? id)
        {
            return await context.Products.FirstOrDefaultAsync(res => res.ID == id);
            
        }

        public async Task<IEnumerable<Product>> GetAll()
        {
            
            return await context.Products.ToListAsync();
            
        }

        public async Task<Product> Update(Product entity)
        {
           
            context.Products.Update(entity);
            await context.SaveChangesAsync();
            return entity;
            
        }
    }
}
