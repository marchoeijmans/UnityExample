using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityTest;

namespace UnitTest
{
    internal class TestMessage : IMessage
    {
        public string Display(string message)
        {
            return "This is a test message.";
        }
    }
}