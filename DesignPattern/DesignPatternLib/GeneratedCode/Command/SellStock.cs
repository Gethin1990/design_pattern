﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成
//     如果重新生成代码，将丢失对此文件所做的更改。
// </auto-generated>
//------------------------------------------------------------------------------
namespace Command
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;

	public class SellStock : IOrder
	{
		public virtual Stock Stock
		{
			get;
			set;
		}

		public virtual void Execute()
		{
			throw new System.NotImplementedException();
		}

	}
}

