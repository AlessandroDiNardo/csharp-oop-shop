namespace csharp_oop_shop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            ESERCIZIO ORIGINALE
                Product firstProduct = new Product("Barbabietole", "Buonissime barbabietole", 10, 22);
                Console.WriteLine($"PRIMO PRODOTTO \n " +
                $"Codice Prodotto: {firstProduct.PadLeft(firstProduct.ProductCode)} \n " +
                $"{firstProduct.FullProductName()} \n " +
                $"Descrzione: {firstProduct.ProductDescription} \n " +
                $"Prezzo: {firstProduct.Price} euro \n " +
                $"Prezzo Completo: {firstProduct.FullPrice()}");
            */

            //BONUS CON ARRAY
            Product[] products = {
                new Product("Latte", "Latte prodotto da Zio Tom", 50, 22),
                new Product("Hamburger", "Miglior hamburger di chianina", 34, 22),
                new Product("Lattuga", "Lattuga buonissima", 15, 22),
                new Product("Patatine", "Patatine San Carlo", 2, 22),
                new Product("Formaggio", "Formaggio Grana Padano", 30, 22),
            };

            //Ciclo foreach per stampa elementi array
            int i = 1;
            foreach (var product in products)
            {
                Console.WriteLine(
                    $"{ i++ } Prodotto \n" +
                    $"Codice Prodotto: {product.PadLeft(product.ProductCode)} \n " +
                    $"{product.FullProductName()} \n " +
                    $"Descrzione: {product.ProductDescription} \n " +
                    $"Prezzo: {product.Price} euro \n " +
                    $"Prezzo Completo: {product.FullPrice()} \n");
            }
        }
    }
}