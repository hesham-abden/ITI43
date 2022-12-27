#include <iostream.h>
#include <conio.h>
class base{
protected:
 int z;
 public:
 base(){}
 base(int m){z=m;}
 getz(){return z;}
 };
 class base1 : virtual public base
 {
 public:
 base1(int f):base(f)
 {z=f;	};
 };
 class base2 :virtual public base
 {
 public:
 base2(int n):base(n)
 {z=n;	};
 };
 class drive :public base1,public base2
 {
 public:
  drive(int x,int y):base1(x),base2(y)
{};

};
int main()
{
drive d(10,5);
cout<<d.getz();
getch();
clrscr();
return 0;
}