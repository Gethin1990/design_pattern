﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成
//     如果重新生成代码，将丢失对此文件所做的更改。
// </auto-generated>
//------------------------------------------------------------------------------
namespace Bridge
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;

	public class GreenCircle : IDrawAPI
	{
		public virtual void DrawCircle(int Radius)
		{
            Console.WriteLine("Drawing Circle: color:Green,redius:" + Radius);
        }

	}
}

