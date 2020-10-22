using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace UdemyNLayerProject.Core.Models
{
    public class Category
    {
        public Category()
        {
            // Category oluşturulunca ilk olarak boş bir Product nesnesi oluşturuyor
            Products = new Collection<Product>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
