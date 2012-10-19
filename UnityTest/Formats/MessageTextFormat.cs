using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnityTest
{
    public class MessageTextFormat : IMessageFormat
    {
        public string CreateFormat()
        {
            return "This is a text format";
        }
    }
}