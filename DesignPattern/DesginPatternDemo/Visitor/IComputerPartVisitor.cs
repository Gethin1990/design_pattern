﻿//------------------------------------------------------------------------------
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

	public interface IComputerPartVisitor 
	{
		void Visit(Computer part);

		void Visit(Keyboard part);

		void Visit(Monitor part);

		void Visit(Mouse part);

	}
}

