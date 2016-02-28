using System.Collections.Generic;
using EveFramework.Entities.DataModels;

namespace EveFramework.Interfaces
{
    public interface IDatabaseService<T> where T : BaseDataModel
    {
        T Save(T entry);

        void Delete(T entry);

        List<T> GetAll();

    }
}