﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成
//     如果重新生成代码，将丢失对此文件所做的更改。
// </auto-generated>
//------------------------------------------------------------------------------
namespace Singleton
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;

	public class SingletonObject
	{
		public static SingletonObject Instance
        {
            get { return new SingletonObject(); }
            set { }
		}

		public virtual void ShowMessage()
		{
            Console.WriteLine("Hello World.");
		}

	}
}

