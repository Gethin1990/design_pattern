﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Memento
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;

	public class Memento: ICloneable
	{
		public virtual string State
		{
			get;
			set;
		}

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}

