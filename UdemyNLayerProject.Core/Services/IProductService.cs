using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UdemyNLayerProject.Core.Models;

namespace UdemyNLayerProject.Core.Services
{
    public interface IProductService:IService<Product>
    {
        // veritabanı harici kodlar da burada yer alır
        Task<Product> GetWithCategoryByIdAsync(int productId);
        //bool ControlInnerBarcode(Product product);

    }
}
