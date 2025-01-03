using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    internal class Customer
    {
        int _custid;
        string _custname;

        public Customer()
        {

        }

        internal void Print()
        {
            Console.WriteLine(_custid);
            Console.WriteLine(_custname);
        }

        public Customer(int customerid)
        {
            _custid = customerid;
        }

        public Customer(string customername)
        {
            _custname = customername;
        }

        public Customer(int customerid, string customername) : this(customerid)
        {
            //_custid = customerid;
            _custname = customername;


        }


        public Customer(string customername, int customerid)
        {
            _custname = customername;
            _custid = customerid;

        }
    }
}
