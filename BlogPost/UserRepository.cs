using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPost
{
    public class UserRepository : Generic<User>
    {
        private List<User> _users;
        public UserRepository()
        {
            _users = new List<User>();
        }
        public async Task<User> GetById(int id)
        {
            return await Task.FromResult(_users.Find(u => u.GetType().GetProperty("ID").GetValue(u).Equals(id)));
        }

        public async Task<List<User>> GetAll()
        {
            return await Task.FromResult(_users);
        }

        public async Task Add(User repos)
        {
            _users.Add(repos);
            await Task.CompletedTask;
        }

        public async Task Delete(User repos)
        {
            _users.Remove(repos);
            await Task.CompletedTask;
        }
    }
}