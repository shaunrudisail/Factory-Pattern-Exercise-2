namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Would you like to use a List, SQL, or Mongo database?");
            Console.WriteLine("Type 'list' to access the List database");
            Console.WriteLine("Type 'sql' to access the SQL database");
            Console.WriteLine("Type 'mongo' to access the Mongo database");
            var userResponse = Console.ReadLine();

            IDataAccess data = DataAccessFactory.GetDataAccessType(userResponse);

            List<Product> products = data.LoadData();
            data.SaveData();

            Console.WriteLine();

            foreach (var product in products)
            {
                Console.WriteLine($"Product Name: {product.Name} | " + $"Product Price: {product.Price,0:c}");
            }
        }
    }
}
