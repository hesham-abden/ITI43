#include <iostream.h>
#include <string.h>
#include <conio.h>
#include<math.h>
class Point{
int x;
int y;
public:
Point(){x=y=0;}
Point(int a,int b){x=a;y=b;}
void setx(int a){x=a;}
void sety(int b){y=b;}
int getx(){return x;}
int gety(){return y;}
};
class Rectangle{
Point p1,p2;
public:
Rectangle(){p1;p2;}
Rectangle(int x1,int x2,int y1,int y2):p1(x1,y1),p2(x2,y2)
{};

int getlength(){return ((p2.getx())-(p1.getx()));}
int getwidth(){return  ((p2.gety())-(p1.gety()));}
int getArea(){return getlength()*getwidth();}
};
class Circle{
Point *p1;
Point *p2;
public:
Circle(){p1;p2;}
Circle(Point *px,Point *py)
{p1=px;p2=py;}
void setpoint1(int x,int y){p1->setx(x);p1->sety(y);}
void setpoint2(int x,int y){p2->setx(x);p2->sety(y);}
Point getp1(){return *p1;}
Point getp2(){return *p2;}
int getlength(){return abs((p2->getx())-(p1->getx()));}
int getwidth(){return  abs((p2->gety())-(p1->gety()));}
double getredius(){return sqrt(abs(pow(getlength(),2)+pow(getwidth(),2)));}
double getArea(){return 3.14*pow(getredius(),2);}
};



int main(){

Point p1(4,3);
Point p2(8,6);
Point p3(0,1);
Circle c1(&p1,&p2);
cout<<"Length:"<<c1.getlength()<<endl<<"Width:"<<c1.getwidth()<<endl;
cout<<"Redius:"<<c1.getredius()<<endl;
cout<<"Area:"<<c1.getArea()<<endl;
c1.setpoint2(0,5);
cout<<"Area2:"<<c1.getArea()<<endl;
//Rectangle rec1(2,5,4,8);
//cout<<rec1.getArea();



getch();
clrscr();
return 0;
}