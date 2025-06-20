﻿using CleanArchitecture.Application.Products.DTOs;

namespace CleanArchitecture.Application.Products
{
   public interface IProductService
    {
        void AddProduct(AddProductDto command);
        void EditProduct(EditProductDto command);
        ProductDto GetProductById(Guid productId);
        List<ProductDto> GetProducts();
    }
}
