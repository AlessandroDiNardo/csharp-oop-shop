namespace csharp_oop_shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product firstProduct = new Product("Barbabietole", "Buonissime barbabietole", 10, 22);
            Console.WriteLine($"PRIMO PRODOTTO \n " +
                $"Codice Prodotto: {firstProduct.PadLeft(firstProduct.ProductCode)} \n " +
                $"{firstProduct.FullProductName()} \n " +
                $"Descrzione: {firstProduct.ProductDescription} \n " +
                $"Prezzo: {firstProduct.Price} euro \n " +
                $"Prezzo Completo: {firstProduct.FullPrice()}");
        }
    }
}