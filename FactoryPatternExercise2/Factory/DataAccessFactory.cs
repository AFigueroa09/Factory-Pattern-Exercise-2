using FactoryPatternExercise2.Classes;
using FactoryPatternExercise2.Interfaces;

namespace FactoryPatternExercise2.Factory
{
    public static class DataAccessFactory
    {
        public static IDataAccess GetDataAccessType(string databaseType)
        {
            switch (databaseType.ToLower()) {
                case "list":
                    return new ListDataAccess();
                case "sql":
                    return new SQLDataAccess();
                case "mongo":
                    return new MongoDataAccess();
                default:
                    throw new NotImplementedException("Valid data base types are: List, SQL, and Mongo");
            };
        }
    }
}
