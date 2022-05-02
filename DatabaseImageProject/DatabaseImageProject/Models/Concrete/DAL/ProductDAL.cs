using DatabaseImageProject.Models.Abstract;
using DatabaseImageProject.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseImageProject.Models.Concrete.DAL
{
    public class ProductDAL : BaseRepository<Product>, IProductRepository
    {
        public ProductDAL(ProductDbContext context) : base(context)
        {

        }
        private ProductDbContext Context
        {
            get { return _context as ProductDbContext; }
        }
        public List<Product> GetPopularProducts()
        {
            throw new System.NotImplementedException();
        }


    }
}
