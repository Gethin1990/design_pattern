﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace AbstractFactory
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;

	public abstract class AbsrtactFactory
	{
		public virtual IShape GetShape(string shapeType)
		{
			throw new System.NotImplementedException();
		}

		public virtual IColor GetColor(string colorType)
		{
			throw new System.NotImplementedException();
		}

	}
}

