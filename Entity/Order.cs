using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    
   public class Order
    {
        private string clientname;

        public string Clientname
        {
            get { return clientname; }
            set { clientname = value; }
        }

      
       private string orderno;
    

public string Orderno
{
  get { return orderno; }
  set { orderno = value; }
}

private string ordertype;

public string Ordertype
{
    get { return ordertype; }
    set { ordertype = value; }
}

private int quantity;

public int Quantity
{
    get { return quantity; }
    set { quantity = value; }
}

private double cost;

public double Cost
{
    get { return cost; }
    set { cost = value; }
}
private string clientnum;

public string Clientnum
{
    get { return clientnum; }
    set { clientnum = value; }
}
private string clientemail;

public string Clientemail
{
    get { return clientemail; }
    set { clientemail = value; }
}

}



}
