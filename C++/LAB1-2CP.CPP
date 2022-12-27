#include <iostream.h>
#include <conio.h>
#include <string.h>
class student{
int id;
char *name;
public:
void setid(int d);
int getid(void);
void setname(char n []);
char *getname(void);
student()
{id=99;
name=new char[5];
strcpy(name,"NAME");
}
~student()
{
  delete(name);
}
student(student &rst);
};
student fillstudent(void);
void printstudent(student s);
int main()
{
student s1,s2;
	printstudent(s1);
	s1=fillstudent();
	s2=fillstudent();
	printstudent(s1);
	printstudent(s2);
/*s1.setid(2);
s1.setname("ABD");
cout<<endl<<"("<<s1.getid()<<","<<s1.getname()<<")";*/



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
delete(student::name);
//cout<<strlen(name)<<endl;
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
 name=new char[strlen(rst.name)+1];
 /*for(int i=0;i<(strlen(rst.name)+1);i++)
 {name[i]=rst.name[i];}*/
 strcpy(name,rst.name);
}



student fillstudent(void)
{
student s;
int x;
char *n;
n=new char[20];
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
