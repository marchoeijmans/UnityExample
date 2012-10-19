using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;

namespace UnityTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Code
            //IUnityContainer container = new UnityContainer();
            //container.RegisterType(typeof(IMessage), typeof(ExtendedMessage));
            //IMessage message = container.Resolve<IMessage>();

            IUnityContainer container = new UnityContainer();
            container.LoadConfiguration("containerOne");
            IMessageSender messageSender = container.Resolve<IMessageSender>();
            Console.WriteLine(messageSender.SendMessage());

            Console.ReadKey();
        }
    }
}