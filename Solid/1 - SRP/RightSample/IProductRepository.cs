using System;

namespace RightSample
{
    public interface IProductRepository
    {
        Task AddProduct(Product product);
    }
}