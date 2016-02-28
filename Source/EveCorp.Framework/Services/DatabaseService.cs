using System.Collections.Generic;
using System.Linq;
using EveFramework.Entities.DataModels;
using EveFramework.Interfaces;
using Umbraco.Core;
using Umbraco.Core.Persistence;

namespace EveFramework.Services
{
    public class DatabaseService<T> : IDatabaseService<T> where T : BaseDataModel
    {
        private readonly string _tablename;
        private static readonly Database _database = ApplicationContext.Current.DatabaseContext.Database;


        public DatabaseService(string tablename)
        {
            _tablename = tablename;
        }

        public T Save(T entry)
        {
            if (entry.Id > 0)
            {
                _database.Update(entry);
            }
            else
            {
                _database.Save(entry);

            }

            return entry;

        }

        public void Delete(T entry)
        {
            _database.Delete(entry);
        }

        public List<T> GetAll()
        {
            var query = new Sql().Select("*").From(_tablename);
            var result = _database.Fetch<T>(query);


            return result?.ToList() ?? new List<T>();
        }
    }
}
