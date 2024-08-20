using BlazorApp.BL.Respoistoires;
using BlazorApp.Model.Enities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp.BL.Services
{
    public interface IProductService
    {
        Task<List<productModel>> GetProducts();

    }

    public class ProductService (IProductRespository productRespository): IProductService
    {
        public Task<List<productModel>> GetProducts()
        {
            return productRespository.GetProducts();  
        
        }

    }
}
