﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Flyweight
{
	using Factory;
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;

	public class ShapeFactory
	{
		public virtual Dictionary<string,string> circleDict
		{
			get;
			set;
		}

		public virtual Square GetCircle()
		{
			throw new System.NotImplementedException();
		}

	}
}
