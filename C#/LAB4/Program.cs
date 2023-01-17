using System;

class LAB4
{
    class Student
    {
        int id;
        string name;
        int[] grades=new int[3];
        public int ID
        { 
          set { id = value; }
          get { return id; }
        }
        public string Name
        {
            set { name = value; }
            get { return name;}
        }
        public int[] Grades
        {
            set { grades = value; }
            get { return grades; }
        }
        public  void SetStudent()
        {
            Console.WriteLine("Enter Your Name : ");
            this.name = Console.ReadLine();
            Console.WriteLine("Enter Your id : ");
            this.id = int.Parse(Console.ReadLine());
            for(int i = 0; i < 3; i++)  
            {
                Console.WriteLine("Enter Your Grade({0}) : ",i+1);
                this.Grades[i] = int.Parse(Console.ReadLine());
            }
        }
        public void PrintStudent()
        {
            Console.WriteLine(this.Name);
            Console.WriteLine(this.ID);
            foreach (int grade in this.Grades)
            { Console.WriteLine(grade); }
        }

    }
    

    public static void Main()
    {
        Student subject= new Student();
        subject.SetStudent();
        subject.PrintStudent();
    }

}