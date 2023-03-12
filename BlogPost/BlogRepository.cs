using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPost
{
    public class BlogRepository : Generic<Blog>
    {
        private List<Blog> _blogs;
        public BlogRepository()
        {
            _blogs = new List<Blog>();
        }
        public async Task<Blog> GetById(int id)
        {
            return await Task.FromResult(_blogs.Find(b => b.GetType().GetProperty("ID").GetValue(b).Equals(id)));
        }

        public async Task<List<Blog>> GetAll()
        {

            return await Task.FromResult(_blogs);
        }

        public async Task Add(Blog repos)
        {
            _blogs.Add(repos);
            await Task.CompletedTask;
        }

        public async Task Delete(Blog repos)
        {
            _blogs.Remove(repos);
            await Task.CompletedTask;
        }
    }
}

