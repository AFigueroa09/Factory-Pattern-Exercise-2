using FactoryPatternExercise2.Interfaces;

namespace FactoryPatternExercise2.Classes
{
    public class MongoDataAccess: IDataAccess
    {
        public void LoadData () {
            Console.WriteLine("I am reading data from Mongo database");
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data to a Mongo database");
        }
    }
}
