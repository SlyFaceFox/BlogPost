using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPost
{
    public class Post
    {
        public int ID { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
    }
}
