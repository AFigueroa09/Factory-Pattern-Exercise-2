using FactoryPatternExercise2.Classes;

namespace FactoryPatternExercise2.Interfaces
{
    public interface IDataAccess
    {
        public abstract List<Product> LoadData();
        public abstract void SaveData();
    }
}
