using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public class Products
    {
		static int _id = 0;

		private int _prodid;


		public int ProductID
		{
			get {
                _prodid = _id + 1;
				_id = _prodid;
                return _prodid;
			}
			
		}


		private string _prodname;

		public string ProductName
		{
			get { return _prodname; }
			set { _prodname = value; }
		}


		static DateTime showtime=new DateTime();

		public static void Greet()
		{
            Console.WriteLine("Greetings of the day....");
		showtime=DateTime.Now;
            Console.WriteLine(showtime);
		
		}


	}
}
