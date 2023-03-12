using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPost
{
    public class PostRepository : Generic<Post>
    {

        private List<Post> _posts;
        public PostRepository()
        {
            _posts = new List<Post>();
        }
        public async Task<Post> GetById(int id)
        {
            return await Task.FromResult(_posts.Find(p => p.GetType().GetProperty("ID").GetValue(p).Equals(id)));
        }

        public async Task<List<Post>> GetAll()
        {
            return await Task.FromResult(_posts);
        }

        public async Task Add(Post repos)
        {
            _posts.Add(repos);
            await Task.CompletedTask;
        }

        public async Task Delete(Post repos)
        {
            _posts.Remove(repos);
            await Task.CompletedTask;
        }

    }
}
