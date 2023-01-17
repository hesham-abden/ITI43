using System;
class Lab1
{
   public struct Employee
    {
        public string name;
        public string address;
        public Position position;
        public Job job;
        public int salary;
    }
    public enum Position { Manager=1, Supervisor, Employee };
    public enum Job { HR=1, Engineer, Accountant };
    public static Employee SetData()
    {
        Employee TempEmp = new Employee();
        Console.WriteLine("Enter Your Name");
        string TempName = Console.ReadLine();
        TempEmp.name = TempName;
        Console.WriteLine("Enter Your Address");
        string TempAddress = Console.ReadLine();
        TempEmp.address = TempAddress;
        Console.WriteLine("Enter Your Salary");
        string sTempSalary = Console.ReadLine();
       int TempSalary = int.Parse(sTempSalary);
        TempEmp.salary = TempSalary;
        Console.WriteLine("Enter Your Job('1:HR,2:Engineer,3:Accountant')");
        string TempJob = Console.ReadLine();
        int temp=int.Parse(TempJob);
        TempEmp.job = (Job)temp;
        //TempEmp.job = (Job)Enum.Parse(typeof(Job),TempJob);  enum method
        Console.WriteLine("Enter Your Position('1:Manager,2:Supervisor,3:Employee')");
        string TempPosition = Console.ReadLine();
        int temp1 = int.Parse(TempPosition);
        TempEmp.position = (Position)temp1;
        //TempEmp.position = (Position)Enum.Parse(typeof(Position), TempPosition); enum method
        return TempEmp;
    }
    public static void GetData(Employee InEmp)
    {
        Console.WriteLine("Name:{0}",InEmp.name);
        Console.WriteLine("Address:{0}", InEmp.address);
        Console.WriteLine("Salary:{0}", InEmp.salary);
        Console.WriteLine("Job:{0}", InEmp.job);
        Console.WriteLine("Position:{0}", InEmp.position);
    }
    
    public static void Main()
    {
        Employee TempEmp;
        TempEmp=SetData();
        GetData(TempEmp);
    }
}