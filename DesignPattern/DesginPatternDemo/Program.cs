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

namespace DesignPatternDemo
{
    static class Program
    {
        static void Main(string[] args)
        {
            //Factory();
            //AbstractFactory();
            //Builder();
            //Prototype();
            Memento();
            //Observer();
            //State();
            //Strategy();
            //Template();
            //Visitor();
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
