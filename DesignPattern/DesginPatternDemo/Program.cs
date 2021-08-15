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
            var factory = new ShapeFactory();
            var circle = factory.GetSharp(ShapeType.Circle);
            circle.Draw();
            var rectangle = factory.GetSharp(ShapeType.Rectangle);
            rectangle.Draw();
        }

        private static void AbstractFactory()
        {
            var factory = new FactoryProducter();
            var colorFactory = factory.GetFactory("color");

            var red = colorFactory.GetColor("red");
            var blue = colorFactory.GetColor("blue");
            var shapeFactory = factory.GetFactory("shape");
            var circle = shapeFactory.GetShape("circle");
            circle.Draw();
            red.Fill();
            blue.Fill();
        }

        private static void Builder()
        {
            var build = new MealBuilder();
            var meal1 = build.prepareNonVegMeal();
            meal1.GetCost();
            foreach (var iMeal in meal1.Items)
            {
                Console.WriteLine($"Name:{iMeal.GetName()}");
                Console.WriteLine($"Price:{iMeal.GetPrice()}");
                Console.WriteLine($"Pack Way:{iMeal.Packing().Pack()}");
            }

        }

        private static void Prototype()
        {
            var circle = new Prototype.Circle{Id="circle"};
            var circle1 = circle.Clone() as Prototype.Shape;
            var circle2 = circle.Clone() as Prototype.Shape;
            Console.WriteLine(circle1?.Id);
            Console.WriteLine(circle2?.Id);

        }

        private static void Adapter()
        {
            var demo = new AdapterDemo();
            demo.Main();
        }
        private static void Bridge()
        {
            var demo = new BridgeDemo();
            demo.Main();
        }

        private static void Chain()
        {
            var demo = new ChainDemo();
            demo.Main();
        }

        private static void Command()
        {
            var demo = new CommandDemo();
            demo.Main();
        }
        private static void Composite()
        {
            var demo = new CompositeDemo();
            demo.Main();
        }

        private static void Facade()
        {
            var demo = new FacadeDemo();
            demo.Main();
        }

        private static void Decorator()
        {
            var demo = new DecoratorDemo();
            demo.Main();
        }

        private static void Flyweight()
        {
            var demo = new FlyweightDemo();
            demo.Main();
        }
        private static void Interpreter()
        {
            var demo = new InterpreterDemo();
            demo.Main();
        }
        private static void Iterator()
        {
            var demo = new IteratorDemo();
            demo.Main();
        }

        private static void Mediator()
        {
            var demo = new MediatorDemo();
            demo.Main();
        }

        private static void Memento()
        {
            var demo = new MementoDemo();
            demo.Main();
        }

        private static void Observer()
        {
            var demo = new ObserverDemo();
            demo.Main();
        }

        private static void Proxy()
        {
            var demo = new ProxyDemo();
            demo.Main();
        }

        private static void State()
        {
            var demo = new StateDemo();
            demo.Main();
        }

        private static void Strategy()
        {
            var demo = new StrategyDemo();
            demo.Main();
        }

        private static void Template()
        {
            var demo = new TemplateDemo();
            demo.Main();
        }

        private static void Visitor()
        {
            var demo = new VisitorDemo();
            demo.Main();
        }
    }
}
