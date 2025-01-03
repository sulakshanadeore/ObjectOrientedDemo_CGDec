
using LogicLibrary;

internal class Program
{
    private static void Main(string[] args)
    {
        //int i = 100;
        //Console.WriteLine($"{i}");
        //Console.WriteLine(i);
        //Console.WriteLine("The value of i= " +  i);

        //Maths m = new Maths();
        //Console.WriteLine("Enter first number");
        //m.FirstNumber = Convert.ToInt32(Console.ReadLine());


        //Console.WriteLine("Enter second number");
        //m.SecondNumber = Convert.ToInt32(Console.ReadLine());

        //int multiAns = m.MultiplyNos();

        //Console.WriteLine($"The multiplication of {m.FirstNumber} * {m.SecondNumber}={multiAns}");

        //Console.WriteLine("-----------------------");
        //Console.WriteLine("Enter radius");
        //m.Radius=Convert.ToInt32(Console.ReadLine());

        //double area=m.CalculateAreaOfCircle();
        //Console.WriteLine(area);

        //User u=new User();
        Customer c=new Customer();
       c.Login("anushka", "Anu@123");
       string isLoggedIn= c.GetTheLoginStatus();
        Console.WriteLine(isLoggedIn);

        //if (status==true)
        //{
        //    Console.WriteLine("Welcome");
        

        //}
        //else {

        //    Console.WriteLine("chekc user id password");
        //    c.GetTheLoginStatus();

        //}
        


        Products.Greet();
        Console.WriteLine("Do u want add products");
        char ans = char.Parse(Console.ReadLine());
        if (ans == 'Y')
        {

            Products p1 = new Products();
            Console.WriteLine("Enter Product Name");
            p1.ProductName = Console.ReadLine();
            Console.WriteLine($"This is the  Product ID=  {p1.ProductID}");

            Products p2 = new Products();
            Console.WriteLine("Enter Product Name");
            p2.ProductName = Console.ReadLine();
            Console.WriteLine($"This is the  Product ID=  {p2.ProductID}");

        }
        else
            Environment.Exit(0);













        //Employee emp = new Employee(101, "Rakshita", "Pune");
        //emp.Print();

        //Console.WriteLine("Hello, World!");
        //Customer c=new Customer();
        //c.Print();
        //Console.WriteLine("-----------------");
        //Customer c1 = new Customer(1, "Ankita");
        //c1.Print();
        //Console.WriteLine("-----------------");
        //Customer c2 = new Customer("Ambika", 3);
        //c2.Print();
        //Console.WriteLine("--------------------");
        //Customer c3 = new Customer(100);
        //c3.Print();
        //Console.WriteLine("--------------------");
        //Customer c4 = new Customer("Sachin");
        //c4.Print();
    }
}