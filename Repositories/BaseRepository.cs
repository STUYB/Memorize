using Memorize.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memorize.Repositories
{
    public abstract class BaseRepository<TEntity> : IDisposable where TEntity : Entity
    {
        protected readonly SqlConnection _connection = new SqlConnection("Data Source=(local);Initial Catalog=Net;Integrated Security=True");
        public BaseRepository()
        {
            _connection.Open();
        }
        public abstract TEntity Insert(TEntity entity);
        public abstract void Update(TEntity entity);
        public abstract List<TEntity> GetAll();
        public void Dispose()
        {
            _connection.Close();
        }
    }
}
