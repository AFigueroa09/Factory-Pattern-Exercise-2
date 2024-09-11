using FactoryPatternExercise2.Interfaces;

namespace FactoryPatternExercise2.Classes
{
    internal class ListDataAccess: IDataAccess
    {
        public void LoadData()
        {
            Console.WriteLine("I am reading data from List");
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data to a List");
        }
    }
}
