namespace LogicLibrary
{
    public class Employee
    {
        int _empid;
        string _name;
        string _city;
        public Employee()
        {

        }
        public Employee(int empid)
        {
            _empid = empid;
        }
        public Employee(int empid, string name) : this(empid)
        {
            // _empid = empid;
            _name = name;
        }
        public Employee(int empid, string name, string City) : this(empid, name)
        {
            //  _empid=empid;   
            //_name = name;
            _city = City;
        }

        public void Print()
        {
            Console.WriteLine(_empid);
            Console.WriteLine(_name);
            Console.WriteLine(_city);
        }

    }
}
