﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Proxy
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;

	public class ProxyDemo
    {
        public void Main()
        {
            IImage image = new ProxyImage();
            image.Display();
        }
    }
}
