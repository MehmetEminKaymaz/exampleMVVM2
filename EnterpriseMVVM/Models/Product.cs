using System;
using System.Collections.Generic;
using System.Text;

namespace EnterpriseMVVM.Models
{
    public  class Product
    {

        public Product(string name,string content,decimal price)
        {
            this.Name = name;
            this.Content = content;
            this.Price = price;
        }

        public Product()
        {

        }

        public string Name { get; set; }
        public string Content { get; set; }
        public decimal Price { get; set; }
        

    }
}
