using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPost
{
    
        public interface Generic<T>
        {
            Task<T> GetById(int id);
            Task<List<T>> GetAll();
            Task Add(T obj);
            Task Delete(T obj);
        }
    
}
