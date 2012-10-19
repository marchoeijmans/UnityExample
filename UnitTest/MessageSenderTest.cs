using System;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnityTest;

namespace UnitTest
{
    /// <summary>
    ///This is a test class for MessageSenderTest and is intended
    ///to contain all MessageSenderTest Unit Tests
    ///</summary>
    [TestClass()]
    public class MessageSenderTest
    {
        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes

        //
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        [TestInitialize()]
        public void MyTestInitialize()
        {
        }

        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //

        #endregion Additional test attributes

        /// <summary>
        ///A test for SendMessage
        ///</summary>
        [TestMethod()]
        public void SendMessageTest()
        {
            // Code
            IUnityContainer container = new UnityContainer();
            container.RegisterType(typeof(IMessage), typeof(TestMessage));
            IMessage message = container.Resolve<IMessage>();

            MessageSender target = new MessageSender(); // TODO: Initialize to an appropriate value
            string actual = target.SendMessage();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}