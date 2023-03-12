using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPost
{
    public class Server
    {
        private Generic<User> _usersServer;
        private Generic<Post> _postsServer;
        private Generic<Blog> _blogsServer;
        public Server(Generic<User> userServ, Generic<Post> postServ, Generic<Blog> blogServ)
        {
            _usersServer = userServ;
            _postsServer = postServ;
            _blogsServer = blogServ;
        }

        public async Task AddBlogInServ(Blog blog)
        {
            if (blog.User != null && _usersServer.GetById(blog.User.ID) != null)
            {
                await _blogsServer.Add(blog);
            }
            else
            {
                Console.WriteLine("Пользователя не существует!");
            }
        }

        public async Task<List<Post>> FindPostsByID(int userId)
        {
            var posts = await _postsServer.GetAll();
            return posts.FindAll(p => p.UserId == userId);
        }

        public async Task<List<Blog>> ReturnAllBlogs()
        {
            return await _blogsServer.GetAll();
        }
    }
}