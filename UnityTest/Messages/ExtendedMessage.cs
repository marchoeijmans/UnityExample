using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnityTest
{
    public class ExtendedMessage : IMessage
    {
        public string Display(string message)
        {
            return message + " is a exented message!";
        }
    }
}