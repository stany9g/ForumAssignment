using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumAssignment
{
    public abstract class BlogAccountBase
    {
        public string Username { get; private set; }

        public string Password { get; private set; }

        protected IBlogInterface blog;
    }
}
