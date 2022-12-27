#include <iostream.h>
#include <conio.h>
class base{
protected:
 int z;
 public:
 base(){z=0;cout<<"DEFAULT BASE"<<endl;}
 base(int m){z=m;cout<<"Parametrized Base"<<endl;}
 getz(){return z;}
 };
 class derive1 :virtual  public base
 {
 public:
 derive1(){cout<<"DEFAULT derive1";};
 derive1(int f):base(f)
 {cout<<"Parametrized derive1"<<endl;};
 };
 class derive2 :virtual public base
 {
 public:
 derive2(){cout<<"DEFAULT derive2"<<endl;};
 derive2(int n):base(n)
 {cout<<"Parametrized derive2"<<endl;};
 };
 class derive :public derive1,public derive2
 {
 public:
 derive(){cout<<"Default derive"<<endl;}
  derive(int x,int y):derive1(x),derive2(y)
 //derive(int x):derive1(x)
{cout<<"Parametrized derive"<<endl;};

};
int main()
{
//derive d(10,5);
derive d(50,100);
cout<<d.derive2::getz();
getch();
clrscr();
return 0;
}