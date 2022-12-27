
#include <iostream.h>
#include <conio.h>
#include <string.h>
class Person{
protected:
int id;
char name[20];
public:
Person(){id=0;strcpy(name,"N/A");}
Person(int x,char n[]){id=x;strcpy(name,n);}
};
class Employee: public Person
{
int salary;
public:
Employee(){salary=0;}
Employee(int x,char n[],int y):Person(x,n)
{salary=y;}
int getsalary(){return salary;}
};

class Customer :public Person
{
char no[13];
public:
Customer(){strcpy(no,"N/A");}
Customer(int x,char n[],char y[]):Person(x,n)
{strcpy(no,y);}
char* getno(){return no;}
};
int main(){

Customer c1(1,"ONE","0111595959"),c2;
Employee em1(2,"Two",1500),em2;
cout<<em1.getsalary();
getch();
clrscr();
return 0 ;
}