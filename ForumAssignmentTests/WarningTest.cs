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
    public class WarningTest
    {
        private StringWriter _outContent = new StringWriter();
        private StringWriter _errContent = new StringWriter();
        private Warning _warning;

        [TestInitialize]
        public void SetUpStreams()
        {
            Console.SetOut(_outContent);
            Console.SetError(_errContent);
            _warning = new Warning("Login failed. Submitted wrong password or username");
        }

        [TestCleanup]
        public void CleanUpStreams()
        {
            Console.SetOut(null);
            Console.SetError(null);
        }
        [TestMethod]
        public void DisplayComponent_displayWarning_warningDisplayedCorrectly()
        {
            // arrange
            string expectedString = "Login failed. Submitted wrong password or username";
            // act
            _warning.DisplayComponent();
            // assert
            Assert.Equals(expectedString, _outContent.ToString());
        }

    }
}
