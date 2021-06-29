﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Builder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class MealBuilder
    {
        public virtual Meal prepareVegMeal()
        {
            var meal = new Meal();
            meal.Items = new Item[] { new VegBurger(), new Coke() };
            return meal;
        }

        public virtual Meal prepareNonVegMeal()
        {
            var meal = new Meal();
            meal.Items = new Item[] { new ChickenBurger(), new Pepsi()};
            return meal;
        }

    }
}
