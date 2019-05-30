using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumAssignment
{
    public interface IBlogInterface
    {
        /// <summary>
        /// Factory method for creating user accounts.
        /// </summary>
        /// <param name="username">Account name serving as a unique identifier across user accounts.</param>
        /// <param name="password">Password, that will be used to log into blog</param>
        /// <param name="admin">Flag deciding, whether newly created object ought to be standard or admin account.</param>
        void CreateNewAccount(string username, string password, bool admin);

        /// <summary>
        /// Method for blocking user account
        /// </summary>
        /// <param name="username">Username of account to be blocked</param>
        void BlockUserAccount(string username);

        /// <summary>
        ///  This method goes through list of users and searches for given username.
        /// </summary>
        /// <param name="username">Name of the blogAccount to be found</param>
        /// <returns>Does the blogAccount exists?</returns>
        bool ExistsUserAccount(string username);

        /// <summary>
        /// This method simulates loginig into the blog. Method goes through list of user accounts searches for user
        /// account.
        /// </summary>
        /// <param name="username">Username of account to return.</param>
        /// <param name="password">Password for searched account.</param>
        /// <returns>UserAccount matching criteria or null.</returns>
        BlogAccountBase Login(string username, string password);

        /// <summary>
        /// This method allows admin to create new Topic for the blog.
        /// </summary>
        /// <param name="topicName">newTopic Unique name of topic to be submitted.</param>
        /// <param name="topicDescription"></param>
        void SubmitNewTopic(string topicName, string topicDescription);

        /// <summary>
        /// Method goes through list of topics and searches for given topic.
        /// </summary>
        /// <param name="topicName">topicName  Name of the topic to be found.</param>
        /// <returns>bool  Does the topic exists?</returns>
        bool ExistsTopic(string topicName);

        /// <summary>
        /// Displaying of List of topics is delegated on to the Dashboard.
        /// Displaying one specific topic is them delegated on to Object Topic itself.
        /// </summary>
        void DisplayTopics();

        /// <summary>
        /// Method for finding specific Topic according to topicName.
        /// </summary>
        /// <param name="topicName">topicName  Name of searched topic</param>
        /// <returns></returns>
        Topic FindTopic(string topicName);

        /// <summary>
        /// Factory method for creating new Posts.
        /// </summary>
        /// <param name="postHeader"></param>
        /// <param name="postContent"></param>
        /// <param name="account"></param>
        void SubmitNewPost(string postHeader, string postContent, BlogAccountBase account);

        /// <summary>
        /// Method for finding specific Post according to postHeader.
        /// </summary>
        /// <param name="postHeader">postHeader  Header of searched Post.</param>
        /// <returns></returns>
        Post FindPost(string postHeader);

        /// <summary>
        /// Method goes through list of posts and searches for given post.
        /// </summary>
        /// <param name="postHeader">Header of post to be found.</param>
        /// <returns>Does the post exists?</returns>
        bool ExistsPost(string postHeader);

        /// <summary>
        /// Method for displaying posts of the blog.
        /// </summary>
        void ReadBlog();

        /// <summary>
        ///  Method for displaying posts of the blog under given topic.
        /// </summary>
        /// <param name="topicName">Name of the topic to be displayed</param>
        void ReadBlog(string topicName);

    }
}
