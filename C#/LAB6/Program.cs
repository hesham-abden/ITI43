using System;


namespace LAB6
{
  public static  class Task1
    {
        public static string Reverse(this string name)
        {
            string temp="";
            for(int i = 0; i < name.Length; i++)
            {
                temp+=name[name.Length-i-1];
            }
            return temp;
        }
    }
     class Lab6
    {
        static void Main(string[] args)
        {
            string test = "hesham123456";
            Console.WriteLine(test.Reverse());
            
        }
    }
}