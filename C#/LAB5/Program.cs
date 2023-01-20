using System.Collections;

namespace LAB5
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int size { get; set; } = 5;
        int[] Grades;
        List<string> hoppies = new List<string>();
        public List<string> Hoppies 
        {
            get
            {
                return hoppies;
            }
           
        }
     public int  this[int index]
        {
            
            get { return Grades[index]; }
            set {Grades[index] = value; }
        }
        public Student()

        {
            Id = 0;
            Name = "N/A";
            Grades = new int[size];



        }
        public Student(int s)
        {
            Id = 0;
            size = s;
            Name = "N/A";
            Grades = new int[s];

        }

        public void PrintStudent()
        {
            int Sum = 0;
            Console.WriteLine("Name : {0}", Name);
            Console.WriteLine("Id : {0}", Id);
            foreach(string s in Hoppies)
            {
                Console.WriteLine("Hoppies : {0}",s);
            }
            for(int i=0;i<size;i++)
            {
                Console.WriteLine("Grade{0} : {1}", i+1,Grades[i]);
                Sum+=Grades[i];
            }
            Console.WriteLine("Sum : {0}", Sum);
            try
            {
                Console.WriteLine("Average : {0}", Sum / size);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e);
            }
            
            
        }
        public void SetGrade()
        {

            try
            {


                for (int i = 0; i < Grades.Length; i++)
                {
                    Console.WriteLine("Grade{0} : ", i);
                    this[i] = int.Parse(Console.ReadLine());
                    
                }
            }
            catch(FormatException e)
            {
                Console.WriteLine(e);
                SetGrade();
            }
            
            
            
        }


    }


    internal class Program
    {
        static void Main()
        {

            Student subject = new Student(3) { Id = 5, Name = "One", Hoppies = { "ONE", "TWO", "THREE" } }; //Constructor with array size, default size = 5 ;
            subject.SetGrade();
            
            subject.PrintStudent();



        }
    }
}