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

	public class Broker 
	{
		public virtual IEnumerable<IOrder> OrderList
		{
			get;
			set;
		}

		public virtual void PlaceOrders()
		{
			throw new System.NotImplementedException();
		}

		public virtual void TakeOrder(IOrder order)
		{
			throw new System.NotImplementedException();
		}

	}
}

