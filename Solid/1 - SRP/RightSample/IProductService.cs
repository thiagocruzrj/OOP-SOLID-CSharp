using System;

namespace RightSample
{
    public interface IProductService
    {
        Task Add(Product product);
    }
}