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

	public class Meal
	{
		public virtual IEnumerable<Item> Items
		{
			get;
			set;
		}

		public virtual float GetCost()
        {
            float cost = 0;
            foreach (var i in Items)
            {
                cost += i.GetPrice();
            }
            return cost;
        }

	}
}

