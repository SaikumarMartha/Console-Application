using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

public class Employee {
     public Employee()  // Default Constructor
    {
        Console.WriteLine("This is default constructor");
    }
    ~Employee()
    {
        Console.WriteLine("Destructor is called");
    }
    public string name;
    public int age;
   
    public static String department = "IT Employee"; // static variable
    
    public Employee(string name, int age)  // Parameterized Constructor
    {
        this.name = name;  // this keyword is ued to call current class variables.
        this.age = age;
    }
    public void display()
    {
        Console.WriteLine(name + " " + age +" "+ department);
    }
    // Override method
    public void show()
    {
        Console.WriteLine("THis is base class");
    }
    private string city;  // Private variable
    public string City  // properties for private variable
    {
        get { return city; }
        set { city = value; }
    }
    //Over loading
    public static int add(int a, int b)
    {
        return  a+b;
    }
    public static int add(int a, int b, int c)
    { return a+b+c; }
}
// Inheritance
public class Employee2 : Employee{
    public void stay()
    {
        Console.WriteLine("This is child class");
    }
   
}

public class Employee3 : Employee2 {
    public void near()
    {
        Console.WriteLine("This is child child class");
    }
    public void show()
    {
        Console.WriteLine("Override method in child class");
    }
}
// Aggregation
public class Address
{
    public string state,country;
    public Employee employee;
    public Address(string state, string country, Employee employee)
    {
        this.state = state;
        this.country = country;
        this.employee = employee;
    }
    public void view()
    {
        Console.WriteLine(state + " " + country+" "+employee.name);
    }

}
// Abstract class
public abstract class Draw
{
    public abstract void draw();
}
public class Circle : Draw
{
    public override void draw()
    {
        Console.WriteLine("Draw Cirlce");
    }
    
}
public class Square : Draw
{
    public override void draw()
    {
        Console.WriteLine("Draw Square");
    }

}
//Interface........................
public interface IShape
{
    void area();
}
public class Rectangle : IShape
{
    public void area()
    {
        int l =20, b =30;
        int a = l * b;
        Console.WriteLine("Area of rectangle" + " " + a);
    }
}
public class Triangle : IShape
{
    public void area()
    {
        int b = 20, h = 30;
        double a = 0.5 * b * h;
        Console.WriteLine("Area of triangle" + " "+a);
    }
}
// Static class with static method
public static class Maths
{
    public static double pi;
    static Maths()  // Static Constructor
    {
        pi = 3.14;
        Console.WriteLine(pi);
    }
    public static int square(int a)
    {
        return a * a;
    }
}
public class Program
{
    private static void Main(string[] args)
    {
      
        Employee emp = new Employee();
        Employee emplo = new Employee("Harsh",25); // No need to create object for static variable
        emplo.display();
        emplo.City = "Hyd";
        Console.WriteLine(emplo.City);
        Console.WriteLine(Maths.square(6));
        Console.WriteLine("Additiojn of 2 numbers"+ Employee.add(2,5));
        Console.WriteLine("Addition of 3 numbers" +Employee.add(5,6,7));
        Employee3 e = new Employee3();
        e.show();
        e.stay();
        e.near();
        //Aggregation
        Employee em = new Employee("Nihal",30);
        Address a = new Address("Mumbai", "India",em);
        a.view();
        //Abstraction
        Draw c = new Circle();
        c.draw();
        Draw s = new Square();
        s.draw();
        Rectangle r = new Rectangle();
        r.area();
        Triangle t = new Triangle();
        t.area();    
    }
}