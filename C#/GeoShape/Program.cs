using System;


class ABS
{
    abstract class GeoShape
    {
      protected  int x;
      protected  int y;
    }
    class Rectangle : GeoShape
    {
        public Rectangle() { }
        public Rectangle(params Rectangle[] list)
        {
            foreach(Rectangle geoShape in list)
            {
                this.x = geoShape.x;
                this.y = geoShape.y;
            }
        }
        public Rectangle(int temp1,int temp2)
        {
            x = temp1;
            y = temp2;
        }
      public static int GetArea(params Rectangle[] Shapes)
        {
            int Area = 0;
            foreach(Rectangle shape in Shapes)
            {
                Area += (shape.x * shape.y);
            }
            return Area;
        }
    }

    public static void Main()
    {
        Rectangle temp1 = new Rectangle(1, 2);
        Rectangle temp2 = new Rectangle(3, 4);
        Rectangle temp3 = new Rectangle(5, 6);
       Console.WriteLine(Rectangle.GetArea(temp1, temp2, temp3));


    }
 

}
