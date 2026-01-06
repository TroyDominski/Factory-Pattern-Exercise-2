namespace FactoryPatternExercise2;

public class ListDataAccess : IDataAccess
{
    
    public static List<Product> Products = new List<Product>()
    {
        new Product() { Name = "Shaker", Price = 15 },
        new Product() { Name = "Guitar", Price = 250 },
        new Product() { Name = "Bass", Price = 350 },
        new Product() { Name = "Drums", Price = 800 },
    };
    public List<Product> LoadData()
    {
        Console.WriteLine("I am loading data from List Data Access.");
        return Products;
    }

    public void SaveData()
    {
        Console.WriteLine("I am saving data to List Data Access.");
        
    }
}