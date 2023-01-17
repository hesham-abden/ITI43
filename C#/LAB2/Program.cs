using System;

class Student
{
    string Name;
    string Password;
   public Student(string ConstructorName,string ConstructorPassword)
    {
        Name=ConstructorName;
        Password= ConstructorPassword;
    }
    public void SetName(string sName) { this.Name = sName; }
    public void SetPassword(string sPassword) { this.Password = sPassword; } 
    public string GetName() { return this.Name; }
    public string GetPassword() { return this.Password; }
}

class LAB2
{   
    public static void Main()
    {
        Student one = new Student("N/A", "N/A");
        Console.WriteLine("Enter Your Name");
        //one.Name = Console.ReadLine();
        one.SetName(Console.ReadLine());
        Console.WriteLine("Enter Your Password");
        one.SetPassword(Console.ReadLine());
        //one.Password = Console.ReadLine();
        if(Compare(one))
        {
            Console.WriteLine("Welcome");
        }
        else 
        {
            Console.WriteLine("Wrong Login");
        }
    }
    public static bool Compare(Student StudentCheck)
    {
      Student temp=new Student("N/A","N/A");
        bool Checker = false;
        Console.WriteLine("Login:");
        Console.WriteLine("Enter Name");
        temp.SetName(Console.ReadLine());
        Console.WriteLine("Enter Password");
        temp.SetPassword(Console.ReadLine());
        if (temp.GetName()==StudentCheck.GetName()&&temp.GetPassword()==StudentCheck.GetPassword())
        {
            Checker = true;
        }
        return Checker;
        
    }

}
