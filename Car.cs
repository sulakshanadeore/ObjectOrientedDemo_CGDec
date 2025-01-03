using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public class Car
    {
        public  void M1()
        { 
        }
        public virtual void M2() { }
    }
    public class SUV : Car 
    {
        public new void M1()
        {
        }
        public virtual void M2() { }
    }
    public class Luxury:SUV
    {

        public new void M1()
        {
        }

        public override void M2()
        {
            base.M2();
        }
    }
}
