using BlazorApp.Databse.Data;
using BlazorApp.Model.Enities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp.BL.Respoistoires
{
    public interface IProductRespository
    {
        Task<List<productModel>> GetProducts();


    }


    public class ProductRespository(AppDbContext dbContext) : IProductRespository
    {
        public Task<List<productModel>> GetProducts()
        {
            return dbContext.products.ToListAsync();
        }
    }
}
