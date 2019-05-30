using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumAssignment
{
    public class Blog : IBlogInterface
    {
        public List<BlogAccountBase> BlogAccounts { get; } = new List<BlogAccountBase>();

        public void BlockUserAccount(string username)
        {
            throw new NotImplementedException();
        }

        public void CreateNewAccount(string username, string password, bool admin)
        {
            throw new NotImplementedException();
        }

        public void DisplayTopics()
        {
            throw new NotImplementedException();
        }

        public bool ExistsPost(string postHeader)
        {
            throw new NotImplementedException();
        }

        public bool ExistsTopic(string topicName)
        {
            throw new NotImplementedException();
        }

        public bool ExistsUserAccount(string username)
        {
            throw new NotImplementedException();
        }

        public Post FindPost(string postHeader)
        {
            throw new NotImplementedException();
        }

        public Topic FindTopic(string topicName)
        {
            throw new NotImplementedException();
        }

        public BlogAccountBase Login(string username, string password)
        {
            throw new NotImplementedException();
        }

        public void ReadBlog()
        {
            throw new NotImplementedException();
        }

        public void ReadBlog(string topicName)
        {
            throw new NotImplementedException();
        }

        public void SubmitNewPost(string postHeader, string postContent, BlogAccountBase account)
        {
            throw new NotImplementedException();
        }

        public void SubmitNewTopic(string topicName, string topicDescription)
        {
            throw new NotImplementedException();
        }
    }
}
