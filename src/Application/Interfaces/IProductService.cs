using Application.DTOs;

namespace Application.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDTO>> GetAllProductsAsync();
        Task<ProductDTO> GetProductByIdAsync(int id);
        Task AddProductAsync(ProductDTO product);
        Task UpdateProductAsync(int id, ProductDTO product);
        Task DeleteProductAsync(int id);
    }
}
