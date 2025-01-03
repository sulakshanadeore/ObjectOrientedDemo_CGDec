using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public class Maths
    {
         float pi=3.14f;
        static Maths()
        {
            Console.WriteLine("I am static constructor");
            Console.WriteLine("I am only called once");
            Console.WriteLine("-----------------------------");
            // pi = 3.14f;
        }

        public Maths()
        {
            Console.WriteLine("I m default constructor");
        }

        double _radius;
       public double Radius
        {
            set { _radius = value; }
            get { return _radius; }
        
        }


        public double CalculateAreaOfCircle()
        {
            return pi * Radius * Radius;
        
        
        }


        
        private  int _fno, _sno;

        //Smart Methods====Accept/Display
        public int FirstNumber 
        {
            set { _fno=value; }
            get { return _fno; }


        }
        public int SecondNumber 
        { 
            set { _sno=value; }
            get { return _sno; }
        }
        public int AddNos()
        {

            return _fno + _sno;
        }
        public int SubtractNos()
        {
            return _fno - _sno;
        }
        public int MultiplyNos()
        {
            return _fno * _sno;
        }
        public int DivideNos()
        {
            return _fno / _sno;
        }




    }
}
