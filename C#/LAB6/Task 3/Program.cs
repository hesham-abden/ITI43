using System.Security.Cryptography.X509Certificates;

namespace Task_3
{
    class Point<G>
    {
        G point1;
        G point2;
      public Point(G point1, G point2)
        {
            this.point1 = point1;
            this.point2 = point2;
            Console.WriteLine(this.ToString());
        }
        public override string ToString()
        {
            return ("Position: X="+point1.ToString()+ ",Y="+point1.ToString());
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Point<int> n = new Point<int>(7, 3);
        }
    }
}