namespace TavernOrderManagement.DataAccessLayer.Services
{
    #region Usings
    using System.Data.SQLite;
    using System.Data;
    using Utilities;
    using System;
    #endregion

    public class SqLiteService : IDisposable
    {
        #region Properties
        private SQLiteConnection _dbConnection;
        #endregion

        #region Constructor
        public SqLiteService()
        {
            _dbConnection = new SQLiteConnection(Vars.ConnStrings.Db);
            _dbConnection.Open();
        }
        #endregion

        #region Public Service Methods
        public DataTable ExecuteQuery(string query)
        {
            var dataTable = new DataTable();

            using (var sqlCmd = new SQLiteCommand(query, _dbConnection))
            using (var sqlRdr = sqlCmd.ExecuteReader())
                dataTable.Load(sqlRdr);

            return dataTable;
        }
        #endregion

        #region Overriden Methods
        public void Dispose()
        {
            _dbConnection.Close();
            _dbConnection.Dispose();
            _dbConnection = null;
        }
        #endregion
    }
}
