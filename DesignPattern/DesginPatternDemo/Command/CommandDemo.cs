//------------------------------------------------------------------------------
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

	public class CommandDemo
	{
        public void Main()
        {
            Stock stock = new Stock();
            var buyStockOrder = new BuyStock { Stock = stock };
            var sellStockOrder = new SellStock { Stock = stock };
            Broker broker = new Broker() { OrderList = new List<IOrder>()};
            broker.TakeOrder(buyStockOrder);
            broker.TakeOrder(buyStockOrder);
            broker.TakeOrder(sellStockOrder);

            broker.PlaceOrders();
        }
	}
}

