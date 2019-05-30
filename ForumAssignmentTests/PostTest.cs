using ForumAssignment;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumAssignmentTests
{
    [TestClass]
    public class PostTest
    {
        private StringWriter _outContent = new StringWriter();
        private StringWriter _errContent = new StringWriter();
        private Post _post;

        [TestInitialize]
        public void SetUpStreams()
        {
            Console.SetOut(_outContent);
            Console.SetError(_errContent);
            _post = new Post("AngularJS", "Cachy content", new AdminAccount("author", "password", null));
        }

        [TestCleanup]
        public void CleanUpStreams()
        {
            Console.SetOut(null);
            Console.SetError(null);
        }

        [TestMethod]
        public void DisplayComponent_displayingUnpublishedPost_postNotDisplayed()
        {
            // arrange
            DateTime lastUpdated = _post.LastUpdated;
            string author = _post.Author.Username;
            string expectedOutput = "";
            // act
            _post.DisplayComponent();
            // assert
            Assert.Equals(expectedOutput, _outContent.ToString());
        }

        [TestMethod]
        public void PublishPost_publishingExistingPost_postPublished()
        {
            // arrange
            bool expectedValue = true;
            // act
            _post.PublishPost();
            // assert
            Assert.Equals(expectedValue, _post.isPublished());
        }

        [TestMethod]
        public void RegisterTopic_registerPostToExistingTopic_postRegisteredToTopic()
        {
            // arrange
            Topic newTopic = new Topic("AngularJS", "Cachy content");
            bool expectedValue = true;
            // act
            _post.RegisterToTopic(newTopic);
            bool actualValue = _post.ArticleTopics.Contains(newTopic);
            // assert
            Assert.Equals(expectedValue, actualValue);
        }

    }
}
