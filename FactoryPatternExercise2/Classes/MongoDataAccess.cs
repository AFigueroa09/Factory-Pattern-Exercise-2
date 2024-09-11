using FactoryPatternExercise2.Interfaces;

namespace FactoryPatternExercise2.Classes
{
    public class MongoDataAccess: IDataAccess
    {
        public List<Product> LoadData () {
            Console.WriteLine("I am reading data from Mongo database");
            return new List<Product>()
            {
                new Product { Name = "Apple", Price = 0.50 },
                new Product { Name = "Beef", Price = 14.50 },
                new Product { Name = "Chicken", Price = 7.50 },
                new Product { Name = "Bread", Price = 1.50 }
            };
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data to a Mongo database");
        }
    }
}
