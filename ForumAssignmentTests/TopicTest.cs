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
    public class TopicTest
    {
        private StringWriter _outContent = new StringWriter();
        private StringWriter _errContent = new StringWriter();
        private Topic _topic;

        [TestInitialize]
        public void SetUpStreams()
        {
            Console.SetOut(_outContent);
            Console.SetError(_errContent);
            _topic = new Topic("AngularJS", "Cachy content");
        }

        [TestCleanup]
        public void CleanUpStreams()
        {
            Console.SetOut(null);
            Console.SetError(null);
        }

        [TestMethod]
        public void DisplayComponent_displayValidComponent_topicDisplayedAccordingly()
        {
            // arrange
            string topicName = _topic.Name;
            string topicDescription = _topic.Description;
            string expectedString = topicName + ": " + topicDescription + "\n";
            // act
            _topic.DisplayComponent();
            // assert
            Assert.Equals(expectedString, _outContent.ToString());
        }

        [TestMethod]
        public void RegisterPost_registerTopicToPost_postRegisteredUnderTopic()
        {
            // arrange
            Post post = new Post("postHeader", "postContent", null);
            bool expectedValue = true;
            // act
            _topic.RegisterPost(post);
            bool actualValue = _topic.Posts.Contains(post);
            // assert
            Assert.Equals(expectedValue, actualValue);
        }

    }
}
