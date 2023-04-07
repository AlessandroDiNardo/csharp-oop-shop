using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    internal class Product
    {
        private int productCode;
        private string productName;
        private string productDescription;
        private decimal price;
        private int iva;

        //codice prodotto solo in lettura
        public int ProductCode
        {
            get 
            { 
                return productCode;
            }
        }

        public string ProductName { get; set; }
        public  string ProductDescription { get; set; } 
        public decimal Price { get; set; }  
        public int Iva { get; set; }

        //funzione per generare codice randomico prodotto
        public Product()
        {
            productCode = new Random().Next(1, 10000);
        }


        //funzione che ha come parametro nome, descrizione, prezzo, iva
        public Product(string productName, string productDescription, decimal price, int iva)
        {
            productCode = new Random().Next(1, 10000);
            ProductName = productName;
            ProductDescription = productDescription;
            Price = price;  
            Iva = iva;
        }

        public decimal FullPrice()
        {
            decimal fullPrice = Price + (Price * Iva / 100);
            return fullPrice;
        }

        public string FullProductName()
        {
            return productCode + " - " + ProductName;
        }
    }
}
