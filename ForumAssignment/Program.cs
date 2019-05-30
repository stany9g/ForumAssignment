using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.1 CREATING NEW ADMIN AND USER ACCOUNT
            /* UNCOMMENT ME WHEN READY
            Blog blog = new Blog();
            string username = "Tom_Hanks";
            string password = "password";
            bool admin = true;
            blog.CreateNewAccount(username, password, admin);
            blog.CreateNewAccount("Nicolas_Cage", "password", false);

            // 1.2 LOGGING INTO THE ADMIN ACCOUNT
            AdminAccount account = (AdminAccount) blog.Login(username, password);

            // 1.3 CREATING NEW TOPICS
            account.CreateNewTopic("AngularJS", "Typical issues encountered using AngularJS, also known as Angular1");
            account.CreateNewTopic("React", "Unlocking hidden power of javascript.");
            account.CreateNewTopic("FrontEnd development", "Various frameworks for frontend development.");

            blog.DisplayTopics();


            // 1.4 WRITING NEW POST
            account.WriteNewPost("Why Angular JS", "HTML is great for declaring static documents, but it falters when we try to use it for declaring dynamic views in web-applications. AngularJS lets you extend HTML vocabulary for your application. The resulting environment is extraordinarily expressive, readable, and quick to develop.\n");
            account.WriteNewPost("Stairway to React", "React makes it painless to create interactive UIs. Design simple views for each state in your application, and React will efficiently update and render just the right components when your data changes.\n");

            // 1.5 REGISTRING POSTS TO TOPICS
            Post angularPost = blog.FindPost("Why Angular JS");
            Post reactPost = blog.FindPost("Stairway to React");
            Topic angularTopic = blog.FindTopic("AngularJS");
            Topic reactTopic = blog.FindTopic("React");
            Topic frontEndTopic = blog.FindTopic("FrontEnd development");

            angularPost.RegisterToTopic(angularTopic);
            angularPost.RegisterToTopic(frontEndTopic);
            reactPost.RegisterToTopic(reactTopic);
            reactPost.RegisterToTopic(frontEndTopic);

            // 1.6 PUBLISHING POST
            angularPost.PublishPost();
            reactPost.PublishPost();

            // 1.8 LOGGING INTO USER ACCOUNT
            UserAccount userAccount = (UserAccount) blog.Login("Nicolas_Cage", password);

            // 1.7 READING DIFFERENT SECTIONS OF BLOG
            userAccount.ReadBlog();
            userAccount.ReadBlog("React");
            userAccount.ReadBlog("AngularJS");
            userAccount.ReadBlog("FrontEnd development");
            userAccount.ReadBlog("BackEnd");
            */
        }
    }
}
