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

	public class TerminalExpression : IExpression
	{
		public virtual string Data
		{
			get;
			set;
		}

		public virtual bool Interpreter(string context)
		{
            if (context.Contains(Data))
            {
                return true;
            }
            return false;
		}

	}
}
