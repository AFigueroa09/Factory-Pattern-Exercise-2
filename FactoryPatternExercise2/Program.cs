using FactoryPatternExercise2.Factory;
using FactoryPatternExercise2.Interfaces;
using FactoryPatternExercise2.Classes;

namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which type of Database would you like to access? (Mongo, List or SQL)");
            var userInput = Console.ReadLine();

            if (userInput == null || userInput == "")
            {
                throw new NullReferenceException("User input must contain a value");
            }

            IDataAccess dataAccess = DataAccessFactory.GetDataAccessType(userInput);
            List<Product> productList = dataAccess.LoadData();
            dataAccess.SaveData();
        }
    }
}
