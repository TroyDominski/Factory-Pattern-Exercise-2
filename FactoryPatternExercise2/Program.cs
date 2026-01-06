namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            bool correctInput;
            do
            {
                correctInput = true;
                

                Console.WriteLine("What database would you like to use: List, SQL, or Mongo?");

                userInput = Console.ReadLine();
                
                if (userInput != "sql" && userInput != "mongo" && userInput != "list")
                {
                    correctInput = false;
                    Console.WriteLine("Invalid input, please try again.");
                }
            } while (!correctInput);
            

            var db = DataAccessFactory.GetDataAccessType(userInput);
            
            var products = db.LoadData();
            db.SaveData();
            
            foreach (var product in products)
            {
                Console.WriteLine($"Name: {product.Name} , Price: {product.Price}");
            }
        }
    }
}
