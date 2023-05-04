using System.Data;

namespace SQLite.API.Classes.Abstract
{
    public interface IDatabaseCRUD
    {
        public string AddedDB(string tableName, int addedCount, int foreignKey);
        public DataTable GetAll(string tableName);
        public DataTable QueryRun(string query);
        public string UpdatedDB(string tableName, int addedCount, int foreignKey);
        public string DeletedDB(string tableName, int addedCount);
    }
}
