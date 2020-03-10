namespace TavernOrderManagement.DataAccessLayer.Services.ModelServices
{
    #region Usings
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Data;
    using System.Linq;
    using System;
    #endregion

    public interface IBaseService<T, TC> where T : class, new() where TC : class, new()
    {
        IEnumerable<T> ListByCriteria(TC criteria);
        int Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }

    public abstract class BaseService<T, TC> : IBaseService<T, TC> where T : class, new() where TC : class, new()
    {
        public IEnumerable<T> ListByCriteria(TC criteria)
        {
            string sqlQuery = CreateSqlQuery(criteria);

            DataTable dataTable;
            using (var sqlSvc = new SqLiteService())
                dataTable = sqlSvc.ExecuteQuery(sqlQuery);

            var entitiesList = RetrieveEntities(dataTable);

            return entitiesList;
        }

        public abstract int Create(T entity);

        public abstract void Update(T entity);

        public abstract void Delete(T entity);

        public IEnumerable<T> RetrieveEntities(DataTable dataTable)
        {
            var lockObj = new object();
            var piecesItems = 100;
            var entitiesList = new List<T>();
            var dataRowList = dataTable.Rows.Cast<DataRow>().ToList();
            if (dataRowList.Count > piecesItems)
            {
                var pieces = dataTable.Rows.Count / piecesItems;
                var piecesMod = dataTable.Rows.Count % piecesItems;
                if (piecesMod > 0) pieces++;

                var callsList = new List<Action>();
                for (var i = 0; i < pieces; i++)
                {
                    var pieceToEdit = dataRowList.Skip(i * 100).Take(100).ToList();

                    callsList.Add(delegate
                    {
                        pieceToEdit.ForEach(x =>
                        {
                            lock (lockObj)
                            {
                                var entity = ConstructEntity(x);
                                if (entity != null)
                                    entitiesList.Add(entity);
                            }
                        });
                    });
                }

                Parallel.Invoke(callsList.ToArray());
            }
            else
            {
                dataRowList.ForEach(x =>
                {
                    lock (lockObj)
                    {
                        var entity = ConstructEntity(x);
                        if (entity != null)
                            entitiesList.Add(entity);
                    }
                });
            }

            return entitiesList.AsEnumerable();
        }

        protected abstract string CreateSqlQuery(TC criteria);

        protected abstract T ConstructEntity(DataRow dataRow);
    }
}
