using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPost
{
    public class Repository<T> : Generic<T> where T : class
    {
        private readonly List<T> _obj;

        public Repository()
        {
            _obj = new List<T>();
        }

        public async Task<T> GetById(int id)
        {
            return await Task.FromResult(_obj.Find(o => o.GetType().GetProperty("Id").GetValue(o).Equals(id)));
        }

        public async Task<List<T>> GetAll()
        {
            return await Task.FromResult(_obj);
        }

        public async Task Add(T entity)
        {
            _obj.Add(entity);
            await Task.CompletedTask;
        }

        public async Task Delete(T entity)
        {
            _obj.Remove(entity);
            await Task.CompletedTask;
        }
    }
}
