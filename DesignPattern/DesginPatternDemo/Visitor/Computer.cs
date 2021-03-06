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

	public class Computer : IComputerPart
	{
		public virtual IEnumerable<IComputerPart> ComputerParts
		{
			get;
			set;
		}

        public Computer()
        {
            ComputerParts = new IComputerPart[] { new Monitor(),new Mouse(),new Keyboard()};
        }

        public virtual void Accept(IComputerPartVisitor visitor)
		{
            foreach (var part in ComputerParts)
            {
                part.Accept(visitor);
            }
            visitor.Visit(this);
		}

	}
}

