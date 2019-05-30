using System;
using System.Linq;
using ForumAssignment;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ForumAssignmentTests
{
    [TestClass]
    public class BlogTest
    {

        private Blog blog;

        private string existingUsername;

        private string existingPassword;

        private string existingTopicName;

        private string existingPostName;

        [TestInitialize]
        public void ExecuteBeforeEach()
        {
            blog = new Blog();
            //  arrange blog user
            existingUsername = "Tom_Hanks";
            existingPassword = "password";
            blog.CreateNewAccount(existingUsername, existingPassword, true);
            //  arrange topic
            existingTopicName = "AngularJS";
            blog.SubmitNewTopic(existingTopicName, "This topic contains all posts related to topic of AngularJS also known as Angular 1.");
            //  arrange post
            existingPostName = "Angular JS for reusable web components.";
            blog.SubmitNewPost(existingPostName, "Angluar is a great for creating reusable web components", null);
        }

        [TestMethod]
        public void CreateNewUser_insertingUniqueUser_userAccountCollectionSizeIncreased()
        {
            //  arrange
            int expectedValue = (blog.BlogAccounts.Count + 1);
            //  act
            blog.CreateNewAccount("Steven_Segal", "password", true);
            //  assert
            Assert.Equals(expectedValue, blog.BlogAccounts.Count);
        }

        [TestMethod]
        public void CreateNewUser_insertDuplicatedUser_userAccountCollectionSizeUnchanged()
        {
            //  arrange
            int expectedValue = blog.BlogAccounts.Count;
            //  act
            blog.CreateNewAccount(existingUsername, existingPassword, true);
            //  assert
            Assert.Equals(expectedValue, blog.BlogAccounts.Count);
        }

        [TestMethod]
        public void ExistsUserAccount_searchExistingUser_returnsTrue()
        {
            //  arrange
            bool expectedValue = true;
            //  act
            bool actualValue = blog.ExistsUserAccount(existingUsername);
            //  assert
            Assert.Equals(expectedValue, actualValue);
        }

        [TestMethod]
        public void ExistsUserAccount_searchNotExistingUser_returnsFalse()
        {
            //  arrange
            bool expectedValue = false;
            //  act
            bool actualValue = blog.ExistsUserAccount("Steven_Segal");
            //  assert
            Assert.Equals(expectedValue, actualValue);
        }

        [TestMethod]
        public void Login_loginExistingUser_userReturned()
        {
            //  arrange
            BlogAccountBase expectedObject = blog.BlogAccounts
                .Where(user => user.Username.Equals(existingUsername) && user.Password.Equals(existingPassword)).First();
            //  act
            BlogAccountBase actualObject = blog.Login(existingUsername, existingPassword);
            //  assert
            Assert.Equals(expectedObject, actualObject);
        }

        [TestMethod]
        public void Login_loginNonExistingUser_returnedNull()
        {
            //  arrange
            UserAccount expectedObject = null;
            //  act
            BlogAccountBase actualObject = blog.Login("Steven_Segal", "password");
            //  assert
            Assert.Equals(expectedObject, actualObject);
        }

        [TestMethod]
        public void Login_loginWithWrongPassword_returnedNull()
        {
            //  arrange
            BlogAccountBase expectedObject = null;
            //  act
            BlogAccountBase actualObject = blog.Login(existingUsername, "wrongPassword");
            //  assert
            Assert.Equals(expectedObject, actualObject);
        }

        [TestMethod]
        public void Login_loginAsBlockedUser_returnedNull()
        {
            //  arrange
            blog.CreateNewAccount("blocked_user", "password", false);
            blog.BlockUserAccount("blocked_user");
            BlogAccountBase expectedObject = null;
            //  act
            BlogAccountBase actualObject = blog.Login("blocked_user", "password");
            //  assert
            Assert.Equals(expectedObject, actualObject);
        }

        [TestMethod]
        public void CreateNewAccount_setAdminFlag_newlyCreatedAccountIsAdminAccount()
        {
            //  arrange
            AdminAccount expectedClass = new AdminAccount("username", "password", null);
            bool admin = true;
            string username = "Nicolas_Fleming";
            //  act
            blog.CreateNewAccount(username, "password", admin);
            //  assert
            Assert.Equals(expectedClass.GetType(), blog.BlogAccounts
                .Where(user => user.Username.Equals(username)).First().GetType());
        }

        [TestMethod]
        public void CreateNewAccount_unsetAdminFlag_newlyCreatedAccountIsUserAccount()
        {
            //  arrange
            UserAccount expectedClass = new UserAccount("username", "password", null);
            bool admin = false;
            string username = "Nicolas_Fleming";
            //  act
            blog.CreateNewAccount(username, "password", admin);
            //  assert
            Assert.Equals(expectedClass.GetType(), blog.BlogAccounts
                .Where(user => user.Username.Equals(username)).First().GetType());
        }

        [TestMethod]
        public void ExistsUserAccount_findExistingAccount_rerturnedTrue()
        {
            //  arrange
            bool expectedValue = true;
            //  act
            bool actualValue = blog.ExistsUserAccount(existingUsername);
            //  assert
            Assert.Equals(expectedValue, actualValue);
        }

        [TestMethod]
        public void ExistsUserAccount_findNonExistingAccount_returnedFalse()
        {
            //  arrange
            string username = "Nicolas_Twisp";
            bool expectedValue = false;
            //  act
            bool actualValue = blog.ExistsUserAccount(username);
            //  assert
            Assert.Equals(expectedValue, actualValue);
        }

        [TestMethod]
        public void SubmitNewTopic_submitUniqueTopic_topicAmountIncreased()
        {
            //  arrange
            int expectedAmount = (blog.BlogTopics.Count + 1);
            //  act
            blog.SubmitNewTopic("React", "All posts regarding React framework.");
            //  assert
            Assert.Equals(expectedAmount, blog.BlogTopics.Count);
        }

        [TestMethod]
        public void SubmitNewTopic_submitDuplicatedTopic_topicAmountUnchanged()
        {
            //  arrange
            int expectedAmount = blog.BlogTopics.Count;
            //  act
            blog.SubmitNewTopic(existingTopicName, "AngularJS best practices.");
            //  assert
            Assert.Equals(expectedAmount, blog.BlogTopics.Count);
        }

        [TestMethod]
        public void ExistsTopic_findExistingTopic_returnedTrue()
        {
            //  arrange
            bool expectedValue = true;
            //  act
            bool actualValue = blog.ExistsTopic(existingTopicName);
            //  assert
            Assert.Equals(expectedValue, actualValue);
        }

        [TestMethod]
        public void ExistsTopic_findNonExistingTopic_returnedFalse()
        {
            //  arrange
            string nonExistingTopic = "Angular2";
            bool expectedValue = false;
            //  act
            bool actualValue = blog.ExistsTopic(nonExistingTopic);
            //  assert
            Assert.Equals(expectedValue, actualValue);
        }

        [TestMethod]
        public void FindTopic_searchExistingTopic_returnedTopic()
        {
            //  arrange
            Topic expectedTopic = blog.BlogTopics
                .Where(topic => topic.Name.Equals(existingTopicName)).First();
            //  act
            Topic actualTopic = blog.FindTopic(existingTopicName);
            //  assert
            Assert.Equals(expectedTopic, actualTopic);
        }

        [TestMethod]
        public void FindTopic_searchNonExistingTopic_returnedNull()
        {
            //  arrange
            Topic expectedTopic = null;
            string nonExistingTopic = "React";
            //  act
            Topic actualTopic = blog.FindTopic(nonExistingTopic);
            //  assert
            Assert.Equals(expectedTopic, actualTopic);
        }

        [TestMethod]
        public void SubmitNewPost_submitValidPost_postsAmountIncreased()
        {
            //  arrange
            int expectedValue = (blog.BlogPosts.Count + 1);
            //  act
            blog.SubmitNewPost("Why using angular?", "Because it is awesome.", null);
            //  assert
            Assert.Equals(expectedValue, blog.BlogPosts.Count);
        }

        [TestMethod]
        public void FindPost_findExistingPost_returnedPost()
        {
            //  arrange
            Post expectedPost = blog.BlogPosts
                .Where(post => post.Header.Equals(existingPostName)).First();

            //  act
            Post actualPost = blog.FindPost(existingPostName);
            //  assert
            Assert.Equals(expectedPost, actualPost);
        }

        [TestMethod]
        public void FindPost_findNonExistingPost_returnedNull()
        {
            //  arrange
            string nonExistingPost = "Angular2";
            Post expectedPost = null;
            //  act
            Post actualPost = blog.FindPost(nonExistingPost);
            //  assert
            Assert.Equals(expectedPost, actualPost);
        }
    }
}
