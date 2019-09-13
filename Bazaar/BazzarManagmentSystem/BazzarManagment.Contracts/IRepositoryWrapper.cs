using System;
using System.Collections.Generic;
using System.Text;

namespace BazzarManagment.Contracts
{
    public interface IRepositoryWrapper
    {
        IProductRepository Product { get; }

    }
}
