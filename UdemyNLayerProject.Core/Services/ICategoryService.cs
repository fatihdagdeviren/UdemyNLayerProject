using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UdemyNLayerProject.Core.Models;

namespace UdemyNLayerProject.Core.Services
{
    public interface ICategoryService:IService<Category>
    {
        // Category'e özgü metodlar burada tanımlanabilir
        Task<Category> GetWithProductsByIdAsync(int categoryId);

    }
}
