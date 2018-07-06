using System;
using System.Diagnostics;
using Autofac;
using static System.Console;

namespace DesignPatterns.Creational.Singleton
{
    public class Foo
    {
        public EventBroker Broker;

        public Foo(EventBroker broker)
        {
            Broker = broker ?? throw new ArgumentNullException(paramName: nameof(broker));
        }
    }

    public class EventBroker
    {

    }
}