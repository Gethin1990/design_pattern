//------------------------------------------------------------------------------
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

	public class AndExpression : IExpression
	{
		public virtual IExpression Expr1
		{
			get;
			set;
		}

		public virtual IExpression Expr2
		{
			get;
			set;
		}

		public virtual bool Interpreter(string context)
		{
            return Expr1.Interpreter(context) && Expr2.Interpreter(context);
        }

	}
}

