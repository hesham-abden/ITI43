using System;
class Inhertiance
{
    class Person
    {
      protected  string name;
      protected  int age;
        public Person(){ }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public int Age
        {
            set { age = value; }
            get { return age; }
        }
    }
    class Employee : Person
    {
        int id;
        public Employee() { }
        public Employee(string n,int a,int i):base(n,a)
        {
            id = i;
        }
        public int Id
        {
            set { id = value; }
            get { return id; }   
        }
        public void PrintEmployer()
        {
            Console.WriteLine("Name : {0}", this.Name);
            Console.WriteLine("Age : {0}", this.Age);
            Console.WriteLine("Id : {0}",this.Id);
        }
        public void SetEmployer()
        {
            Console.WriteLine("Enter Your Name : ");
            this.name = Console.ReadLine();
            Console.WriteLine("Enter Your Age : ");
            this.age =int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your Id : ");
            this.id =int.Parse(Console.ReadLine());

        }
    }
    class Customer : Person
    {
        string phone;
        public Customer() { }
        public Customer(string n, int a, string p):base(n,a)
        {
            phone = p;
        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public void PrintCustomer()
        {
            Console.WriteLine("Name : {0}", this.Name);
            Console.WriteLine("Age : {0}", this.Age);
            Console.WriteLine("Id : {0}", this.Phone);
        }
        public void SetEmployer()
        {
            Console.WriteLine("Enter Your Name : ");
            this.name = Console.ReadLine();
            Console.WriteLine("Enter Your Age : ");
            this.age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your phone : ");
            this.phone = Console.ReadLine();
        }

    }

    public static void Main()
    {
        Employee subject = new Employee();
        subject.SetEmployer();
        subject.PrintEmployer();
    }

}