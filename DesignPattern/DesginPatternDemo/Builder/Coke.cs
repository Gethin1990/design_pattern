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

	public class Coke : Drink
	{
        public override IPacking Packing()
        {
            return base.Packing();
        }

        public override float GetPrice()
        {
            return (float) 1.50;
        }

        public override string GetName()
        {
            return "Coke";
        }

	}
}
