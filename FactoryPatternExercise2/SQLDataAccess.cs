namespace FactoryPatternExercise2;
using System.Collections.Generic;
public class SQLDataAccess : IDataAccess
{ 
    public void SaveData()
    {
        Console.WriteLine("Saving data to the SQL database. . .");
    }
    
    public List<Product> LoadData()
    {
        Console.WriteLine("Reading data from the SQL database. . .");
        
        return new List<Product>()
        {
            new Product() { Name = "Metroid Prime 4: Beyond", Price = 79.99m },
            new Product()
                { Name = "Jackson Pro Series Signature Dave Davidson Warrior WR7 Electric Guitar", Price = 1469.99m },
            new Product() { Name = "MacBook Pro 16-inch M4 Max", Price = 3999.99m },
            new Product() { Name = "Nintendo Switch 2", Price = 449.99m }
        };
    }
}