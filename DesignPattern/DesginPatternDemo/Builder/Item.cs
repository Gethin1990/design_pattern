//------------------------------------------------------------------------------
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

	public abstract class Item
	{
		public abstract IPacking Packing();

		public abstract float GetPrice();

		public abstract string GetName();

	}
}

