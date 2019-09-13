using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BazzarManagment.DAL.Models;

namespace BazzarManagment.Contracts
{
    public interface IProductRepository : IRepositoryBase<Product>
    {
        Task<IEnumerable<Product>> GetAllProductsAsync();
        Task<Product> GetProductByIdAsync(Guid ProductId);
        Task CreateProductAsync(Product Product);
        Task UpdateProductAsync(Product dbProduct,  Product product);
        Task DeleteProductAsync(Product Product);
        string ExportProductExcel(IEnumerable<Product> product);
    }
}
