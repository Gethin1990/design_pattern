//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Visitor
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;

	public class ComputerPartVisitor : IComputerPartVisitor
	{
		public virtual void Visit(Computer part)
		{
			Console.WriteLine("Displaying Computer.");
		}

		public virtual void Visit(Keyboard part)
		{
            Console.WriteLine("Displaying Keyboard.");
		}

		public virtual void Visit(Monitor part)
		{
            Console.WriteLine("Displaying Monitor.");
		}

		public virtual void Visit(Mouse part)
		{
            Console.WriteLine("Displaying Mouse.");
		}

	}
}

