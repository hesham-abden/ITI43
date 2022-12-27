#include <iostream.h>
#include <conio.h>
#include <string.h>
class student{
int id;
char name[20];
public:
void setid(int d);
int getid(void);
void setname(char n []);
char *getname(void);
};

student fillstudent(void);
void printstudent(student s);
int main()
{
student s1[3];
	for(int i=0;i<3;i++){
	s1[i]=fillstudent();
			}
	for(i=0;i<3;i++){
	printstudent(s1[i]);
	}
student test;
test.setid(1);
test.setname("test");
cout<<endl<<"("<<test.getid()<<","<<test.getname()<<")";



getch();
clrscr();
return 0;
}
void student::setid(int d)
{
id=d;
}

int student::getid(void)
{return id;}

void student::setname(char n[])
{
strcpy(name,n);
}
char* student::getname(void)
{
 return name;
}

student fillstudent(void)
{
student s;
int x;
char n[20];
cout<<"Enter ID:";
cin>>x;
s.setid(x);
cout<<"Enter Name:";
cin>>n;
s.setname(n);
return s;
}
void printstudent(student s)
{
 cout<<"(ID : "<<s.getid()<<",Name : "<<s.getname()<<")"<<endl;
}
