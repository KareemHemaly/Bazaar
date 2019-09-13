using BazzarManagment.Contracts;
using BazzarManagment.DAL;
using BazzarManagment.Repo;

namespace ProductCatalog.Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private BazarContext _repoContext;
        private IProductRepository _Product;
   
        

        public IProductRepository Product
        {
            get
            {
                if (_Product == null)
                {
                    _Product = new ProductRepository(_repoContext);
                }

                return _Product;
            }
        }

        public RepositoryWrapper(BazarContext repositoryContext)
        {
            _repoContext = repositoryContext;
        }
    }
}
