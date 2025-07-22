namespace FactoryPatternExercise2;
using System.Collections.Generic;
public interface IDataAccess
{
    public List<Product> LoadData();
    public void SaveData();
}