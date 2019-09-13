using BazzarManagment.Contracts;
using BazzarManagment.DAL;
using BazzarManagment.DAL.Models;
using Microsoft.EntityFrameworkCore;
using ProductCatalog.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazzarManagment.Repo
{
    class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(BazarContext repositoryContext): base(repositoryContext)
        {
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            return await GetAll()
                 .OrderBy(x => x.Name)
                 .ToListAsync();
        }

        public async Task<Product> GetProductByIdAsync(Guid ProductId)
        {
            return await GetByCondition(o => o.Id.Equals(ProductId))
                  .DefaultIfEmpty(new Product())
                  .SingleAsync();
        }
        public async Task CreateProductAsync(Product Product)
        {
            Product.Id = Guid.NewGuid();
            Product.DateCreated = DateTime.UtcNow.AddHours(2);
            Product.LastUpated = DateTime.UtcNow.AddHours(2); 
            Create(Product);
            await SaveChangesAsync();
        }

        public async Task UpdateProductAsync(Product dbProduct, Product Product)
        {

            //dbProduct.Map(Product);
            dbProduct.LastUpated = DateTime.UtcNow.AddHours(2);
            Update(dbProduct);
            await SaveChangesAsync();
        }

        public async Task DeleteProductAsync(Product Product)
        {
            Delete(Product);
            await SaveChangesAsync();
        }

        public string ExportProductExcel(IEnumerable<Product> ProductsCatalog)
        {
            throw  new NotImplementedException(); 
        }

        public DataTable ConvertToDataTable<T>(IList<T> data)
        {

            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));

            DataTable table = new DataTable();

            foreach (PropertyDescriptor prop in properties)

            table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);

            foreach (T item in data)

            {

                DataRow row = table.NewRow();

                foreach (PropertyDescriptor prop in properties)

                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;

                table.Rows.Add(row);

            }

            return table;

        }
    }
}

