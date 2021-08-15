﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成
//     如果重新生成代码，将丢失对此文件所做的更改。
// </auto-generated>
//------------------------------------------------------------------------------
namespace Interpreter
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;

	public class InterpreterDemo
	{
		public virtual IExpression GetMaleExpression()
		{
            var robert = new TerminalExpression{ Data = "Robert" };
            var john = new TerminalExpression { Data = "John" };
            return new AndExpression {Expr1 = robert,Expr2= john };
        }

		public virtual IExpression GetMarriedWomenExpression()
		{
            var julie = new TerminalExpression { Data = "Julie" };
            var married = new TerminalExpression { Data = "Married" };
            return new OrExpression { Expr1 = julie, Expr2 = married };
        }

        public void Main()
        {
            var isMale = GetMaleExpression();
            var isMarriedWoman = GetMarriedWomenExpression();
            Console.WriteLine($"John is male? {isMale.Interpreter("John")}");
            Console.WriteLine($"Julie is a married women?? {isMarriedWoman.Interpreter("Married Julie")}");
        }

	}
}

