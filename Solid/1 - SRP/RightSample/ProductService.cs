using System;

namespace RightSample
{
    public class ProductService : IProductService
    {
        private readonly ILogger _logger;
        private readonly IProductRepository _productRepository;

        public ProductService(ILogger logger, IProductRepository productRepository)
        {
            _logger = logger;
            _productRepository = productRepository;
        }

        public async Task Add(Product product)
        {
            _logger.Log("Adding new product");

            try
            {
                if(!product.IsValid) return "Invalid Product";

                _productRepository.AddProduct(product);
            } catch(Exception ex)
            {
                _logger.Log(ex.Message, "Error to add a product");
                return ex.Message;
            }
        }
    }
}