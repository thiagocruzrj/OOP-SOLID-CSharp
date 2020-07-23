using System;

namespace RightSample
{
    public class ProductRepository : IProductRepository
    {
        private readonly ILogger _logger;
        private readonly string _connectionString;
        public ProductRepository(ILogger logger, string connectionString)
        {
            _logger = logger;
            _connectionString = connectionString;
        }

        private const string InsertProduct = "INSERT INTO PRODUCT(Name,Description) VALUES (@name,@description)";

        public async Task AddProduct(Product product)
        {
            _logger.Log("Adding a new product");
            try
            {
                await using var connection = new SqlConnection(_connectionString);
                connection.Open();
                var transaction = connection.BeginTransction();

                var queryParameters = new
                {
                    name = product.Name,
                    description = product.Description
                };

                transaction.Connection.Query(InsertProduct, queryParameters).Single();

                transaction.Commit();
                _logger.Log("Product saved");
            } catch (Exception ex)
            {
                _logger.Log(ex, "Error to add product");
                throw;
            }
        }
    }
}