﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成
//     如果重新生成代码，将丢失对此文件所做的更改。
// </auto-generated>
//------------------------------------------------------------------------------
namespace Composite
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Employee
    {
        public virtual string Name
        {
            get;
            set;
        }

        public virtual string Department
        {
            get;
            set;
        }

        public virtual List<Employee> Subordinates
        {
            get;
            set;
        }

        public virtual void Add(Employee e)
        {
            Subordinates.Add(e);
        }

        public virtual void Remove(Employee e)
        {
            Subordinates.Remove(e);
        }

    }
}
