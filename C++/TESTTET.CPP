#include <iostream.h>
#include <conio.h>
#include <string.h>
class Shape
{
protected:
int d1,d2;
public:
Shape(){d1=d2=0;}
Shape(int x,int y){d1=x;d2=y;}
void setd1(int m){d1=m;}
void setd2(int n){d2=n;}
int getd1(){return d1;}
int getd2(){return d2;}
virtual float Area()=0;
};

class Rectangle:public Shape
{
public:
Rectangle(){}
Rectangle(int x,int y):Shape(x,y){}
float Area(){return d1*d2;}
};

class Circle:public Shape
{
public:
Circle(){}
Circle(int r):Shape(r,r){}
float Area(){return 3.14*d1*d2;}
};

class Triangle:public Shape
{
public:
Triangle(){}
Triangle(int x,int y):Shape(x,y){}
float Area(){return 0.5*d1*d2;}
};

class Square:public Rectangle
{
public:
Square(){}
Square(int x):Rectangle(x,x){}
};
class Geoshape
{
Shape **p;
public:
Geoshape(){}
Geoshape(Shape **p1)
{
p=p1;
}
float Total_Area();
};
float Geoshape::Total_Area()
{
float total=0;
/*for(int i=0;i<3;i++)
	{
	 total+=p[i]->Area();
	}*/
	total+=p[0]->Area();
       total+=p[1]->Area();
   return total;
   }
int main(){
Circle c(2),c2(2);
Rectangle r(2,2);
Shape *s[2];
//s=new Circle[2];
s[0]=&c;
s[1]=&r;
Geoshape s1(s);
cout<<s1.Total_Area()<<endl;
getch();
clrscr();
return 0;
}