using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory;
using Builder;
using Factory;
using Prototype;
using ShapeFactory = Factory.ShapeFactory;

namespace DesignPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Factory();
            //AbstractFactory();
            //Builder();
            Prototype();
        }

        private static void Factory()
        {
            var factory = new ShapeFactory();
            var circle = factory.GetSharp(ShapeType.Circle);
            circle.Draw();
            var rectangle = factory.GetSharp(ShapeType.Rectangle);
            rectangle.Draw();
            Console.ReadLine();
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
            Console.ReadLine();
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
            Console.ReadLine();

        }

        private static void Prototype()
        {
            var circle = new Prototype.Circle{Id="circle"};
            var circle1 = circle.Clone() as Prototype.Shape;
            var circle2 = circle.Clone() as Prototype.Shape;
            Console.WriteLine(circle1?.Id);
            Console.WriteLine(circle2?.Id);
            Console.ReadLine();

        }
    }
}
