using System;
using AbstractFactory;
using Builder;
using Factory;
using Memento;
using Observer;
using State;
using Strategy;
using Template;
using Visitor;
using ShapeFactory = Factory.ShapeFactory;
using Mediator;
using Iterator;
using Interpreter;
using Flyweight;
using Facade;
using Decorator;
using Chain;
using Command;
using Bridge;
using Adapter;
using Proxy;
using Composite;
using Singleton;
using Prototype;

namespace DesignPatternDemo
{
    static class Program
    {
        static void Main(string[] args)
        {
            /*创建型*/

            AbstractFactory();
            Factory();
            Builder();
            Singleton();
            Prototype();

            /*结构型*/

            Adapter();
            Proxy();
            Bridge();
            Composite();
            Decorator();
            Facade();
            Flyweight();

            /*行为型*/

            Chain();
            Command();
            Mediator();
            Observer();
            Iterator();
            Memento();
            Interpreter();
            Strategy();
            Visitor();
            State();
            Template();

            Console.ReadLine();
        }

        private static void Factory()
        {
            Console.WriteLine("Factory:");

            var demo = new FactoryDemo();
            demo.Main();
        }

        private static void AbstractFactory()
        {
            Console.WriteLine("AbstractFactory:");

            var demo = new AbstractFactoryDemo();
            demo.Main();
        }

        private static void Builder()
        {
            Console.WriteLine("Builder:");

            var demo = new BuilderDemo();
            demo.Main();
        }

        private static void Prototype()
        {
            Console.WriteLine("Prototype:");

            var demo = new PrototypeDemo();
            demo.Main();
        }

        private static void Singleton()
        {
            Console.WriteLine("Singleton:");

            var demo = new SingletonDemo();
            demo.Main();
        }
        private static void Adapter()
        {
            Console.WriteLine("Adapter:");

            var demo = new AdapterDemo();
            demo.Main();
        }
        private static void Bridge()
        {
            Console.WriteLine("Bridge:");

            var demo = new BridgeDemo();
            demo.Main();
        }

        private static void Chain()
        {
            Console.WriteLine("Chain:");

            var demo = new ChainDemo();
            demo.Main();
        }

        private static void Command()
        {
            Console.WriteLine("Command:");

            var demo = new CommandDemo();
            demo.Main();
        }
        private static void Composite()
        {
            Console.WriteLine("Composite:");

            var demo = new CompositeDemo();
            demo.Main();
        }

        private static void Facade()
        {
            Console.WriteLine("Facade:");

            var demo = new FacadeDemo();
            demo.Main();
        }

        private static void Decorator()
        {
            Console.WriteLine("Decorator:");

            var demo = new DecoratorDemo();
            demo.Main();
        }

        private static void Flyweight()
        {
            Console.WriteLine("Flyweight:");

            var demo = new FlyweightDemo();
            demo.Main();
        }
        private static void Interpreter()
        {
            Console.WriteLine("Interpreter:");

            var demo = new InterpreterDemo();
            demo.Main();
        }
        private static void Iterator()
        {
            Console.WriteLine("Iterator:");

            var demo = new IteratorDemo();
            demo.Main();
        }

        private static void Mediator()
        {
            Console.WriteLine("Mediator:");

            var demo = new MediatorDemo();
            demo.Main();
        }

        private static void Memento()
        {
            Console.WriteLine("Memento:");

            var demo = new MementoDemo();
            demo.Main();
        }

        private static void Observer()
        {
            Console.WriteLine("Observer:");

            var demo = new ObserverDemo();
            demo.Main();
        }

        private static void Proxy()
        {
            Console.WriteLine("Proxy:");

            var demo = new ProxyDemo();
            demo.Main();
        }

        private static void State()
        {
            Console.WriteLine("State:");

            var demo = new StateDemo();
            demo.Main();
        }

        private static void Strategy()
        {
            Console.WriteLine("Strategy:");

            var demo = new StrategyDemo();
            demo.Main();
        }

        private static void Template()
        {
            Console.WriteLine("Template:");

            var demo = new TemplateDemo();
            demo.Main();
        }

        private static void Visitor()
        {
            Console.WriteLine("Visitor:");

            var demo = new VisitorDemo();
            demo.Main();
        }
    }
}
