#include <iostream.h>
#include <conio.h>
#include <string.h>
class student{
int id;
char *name;
int grade;
public:
void setid(int d);
int getid(void);
void setgrade(int d);
int getgrade(void);
void setname(char n []);
char *getname(void);
student()
{id=999;
grade=0;
name=new char[8];
strcpy(name,"Default");
}
student(int d)
{
 id=d;
 grade=0;
 name=new char[7];
 strcpy(name,"Second");
}
student(int d,char n[])
{
 id=d;
 grade=0;
 name=new char[(strlen(n)+1)];
 strcpy(name,n);
}
~student()
{
  delete(name);
}
student(student &rst);
student operator=(student s)
{
id=s.id;
grade=s.grade;
delete(name);
name=new char[(strlen(s.name)+1)];
strcpy(name,s.name);
return *this;
}



};
student fillstudent(void);
void printstudent(student s);
int main()
{
student s1;
student s2(88);
student s3(77,"Third");
cout<<"("<<s1.getid()<<","<<s1.getname()<<")";
cout<<endl<<"("<<s2.getid()<<","<<s2.getname()<<")";
cout<<endl<<"("<<s3.getid()<<","<<s3.getname()<<")"<<endl;
s1=fillstudent();
printstudent(s1);
getch();
clrscr();
return 0;
}
void student::setid(int d)
{
id=d;
}
void student::setgrade(int d)
{
grade=d;
}
int student::getid(void)
{return id;}
int student::getgrade(void)
{return grade;}
void student::setname(char n[])
{
delete(name);
name=new char[strlen(n)+1];
strcpy(name,n);
}
char* student::getname(void)
{
 return name;
}
student::student(student &rst)
{
 id=rst.id;
 grade=rst.grade;
 name=new char[strlen(rst.name)+1];
 strcpy(name,rst.name);
}



student fillstudent(void)
{
student s;
int x;
int g;
char *n;
n=new char[30];
cout<<"Enter ID:";
cin>>x;
cout<<"Enter Grade:";
cin>>g;
s.setid(x);
s.setgrade(g);
cout<<"Enter Name:";
cin>>n;
s.setname(n);
return s;
}
void printstudent(student s)
{
 cout<<"(ID: "<<s.getid()<<",Grade: "<<s.getgrade()<<",Name: "<<s.getname()<<")"<<endl;
}
