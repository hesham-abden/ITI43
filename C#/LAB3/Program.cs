using System;
class LAB3
{
    



    public static void SetStudentGrade(int [][]Student) {
        for (int i = 0; i < Student.Length; i++)
        {
            int TempNumber = 0;
            Console.WriteLine("Student{0} Number of Subjects : ", i + 1);
            TempNumber=int.Parse(Console.ReadLine());
            Student[i] = new int[TempNumber];
            for (int j = 0; j < TempNumber; j++)
            {   
                Console.WriteLine("Enter the grade of subject{0} : ", j + 1);
                Student[i][j]= int.Parse(Console.ReadLine());
            }
        }
    }
    public static void PrintStudents(int[][]Student)
    {
        for (int i = 0; i < Student.Length; i++)
        {

            int TempSumAvg = 0;
            for (int j = 0; j < Student[i].Length; j++)
            {
                Console.WriteLine("Student({0});Subject({1}) Grade = {2}", i + 1, j + 1, Student[i][j]);
                TempSumAvg+=Student[i][j]; 
            }
            Console.WriteLine("Grade Sum for Student({0}) = {1}", i + 1, TempSumAvg);
            Console.WriteLine("Grade Average for Student({0}) = {1}", i + 1, (TempSumAvg / Student[i].Length));
        }

    }


    public static void Main()

    {
        int[][] Student = new int[2][];
        SetStudentGrade(Student);
        PrintStudents(Student);
    }

}