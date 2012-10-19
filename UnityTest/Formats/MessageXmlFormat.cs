using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnityTest
{
    public class MessageXmlFormat : IMessageFormat
    {
        public string CreateFormat()
        {
            return "This is an Xml Format";
        }
    }
}