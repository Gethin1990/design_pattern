//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace State
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;

	public class StateDemo
	{
        public void Main()
        {
            Context context = new Context();

            IState state = new StartState(){Context = context};
            state.Action();
            Console.WriteLine(context.IState);

            state = new StopState(){Context = context};
            state.Action();
            Console.WriteLine(context.IState);

        }
    }
}

