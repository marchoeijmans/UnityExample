using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;

namespace UnityTest
{
    public class MessageSender : IMessageSender
    {
        private IMessage message;
        private IMessageFormat messageFormat;

        [Dependency]
        public IMessageFormat MessageFormat
        {
            get { return messageFormat; }
            set { messageFormat = value; }
        }

        public MessageSender()
        {
            IUnityContainer container = new UnityContainer();
            container.LoadConfiguration("containerOne");
            message = container.Resolve<IMessage>();
        }

        public string SendMessage()
        {
            return string.Format("Send message: {0} with format {1}", message.Display("Hello world."), messageFormat.CreateFormat());
        }
    }
}