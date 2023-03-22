namespace LINQi_töö
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ThenBy();
            Console.WriteLine("---------------------");
            LastOrDefault();
            Console.WriteLine("---------------------");
        }
        //ThenBy sorteerib muutujaid pärast OrderBy-t.
        //ThenBy sorteerib üldiselt ja OrderBy sorteerib spetsiifilises järjekorras.
        public static void ThenBy()
        {
            Console.WriteLine("Then By");
            Console.WriteLine("Product list");
            
            var thenByResult = ProductList.products
                .OrderBy(x => x.Id)
                .ThenBy(x => x.Name); //Siin on produktid üldises järjekordades pandud

            foreach (var product in thenByResult)
            {
                Console.WriteLine("Product name: " + product.Name + " | " + "Product Id: " + product.Id);
            }

        }
        //LastOrDefault kasutatakse selleks, et näidata või kustutada viimast muutujat ning jätab teised muutujad välja.
        //Kui on puudujääk e. default ehk mingi muutuja ei eksisteeri koodis, siis näitab selle asemel nulli.
        public static void LastOrDefault()
        {
            Console.WriteLine("Last Or Default");
            
            var lastOrDefault = ProductList.products.LastOrDefault();
            var lastOrDefault2 = ProductList.products.LastOrDefault();

            Console.WriteLine("Product: " + lastOrDefault.Name + " | " + "Id: " + lastOrDefault2.Id);

        }
      



    }
}