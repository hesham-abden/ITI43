#include <iostream.h>
#include <conio.h>
#include <string.h>
class student{
int id;
char *name;
int grade;
static int count;
static char school_name[];
public:
void setid(int d);
int getid(void);
void setgrade(int d);
int getgrade(void);
void setname(char *n);
 char *getname(void);
static int getcount(void);
static void setschool_name( char n[]);
static char* getschool_name(void);
student()
{id=999;
grade=0;
name=new char[8];
strcpy(name,"Default");
count++;
}
student(int d,int g=0)
{
 id=d;
 grade=g;
 name=new char[7];
 strcpy(name,"Second");
 count++;
}
student(int d,int g=0,char n[])
{
 id=d;
 grade=g;
 name=new char[(strlen(n)+1)];
 strcpy(name,n);
 count++;
}
~student()
{
  delete(name);
  count--;
}
student(student &rst);
student operator=(student s);
student operator+(student s);
student operator+(int m);
friend student operator+(int m,student s);
student operator+(char *n);
friend student operator+(char *n,student s);
operator char*();
operator int();
student operator++();
student operator++(int d);
int operator==(student s);
};
student fillstudent(void);
void printstudent(student s);
int student::count=0;
char student::school_name[20]={"ITI"};
int main()
{
student s1[5];
//student s2;
//s1=fillstudent();
//s2=fillstudent();
student s3;
//s3=s1+s2;              //s1+s2
//s3=s1+5;               //s1+5
//s3=5+s1;               //5+s1
//s3=s1+"NEW";           //s1+""
//s3="NEW"+s1;           //""+s1
//char *n=(char*) s1;    //type casting (char*)
//cout<<endl<<n<<endl;
//int k=(int)s1;         //type casting (int)
//cout<<endl<<k<<endl;
//s3=s1++;               //post-increment
//s3=++s1;
//s3=s1;               //pre-increment
//if(s1==s3){            //equal
//cout<<endl<<"EQUAL"<<endl;}
//printstudent(s1);
//printstudent(s2);
//printstudent(s3);
cout<<student::getschool_name()<<endl;
student::setschool_name("HESHAM");
cout<<student::getschool_name()<<endl;
cout<<student::getcount()<<endl;


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
void student::setname(char *n)
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
 count++;
}
int student::getcount(void)
{return count;}
void student::setschool_name(char n[])
{strcpy(school_name,n);}
char*  student::getschool_name(void)
{return school_name;}








student student::operator=(student s)
{
id=s.id;
grade=s.grade;
delete(name);
name=new char[(strlen(s.name)+1)];
strcpy(name,s.name);
return *this;
};

student student::operator+(student s)
{
student temp;
temp.grade=grade+s.grade;
temp.id=99;
temp.name=new char[strlen(name)+strlen(s.name)+2];
strcpy(temp.name,name);
strcat(temp.name," ");
strcat(temp.name,s.name);
return temp;
}


student student::operator+(int m)
{
student temp(*this);
temp.grade+=m;
return(temp);
}
student operator+(int m,student s)
{return s+m;}
student student::operator+(char *n)
{
student temp(*this);
delete(temp.name);
temp.name=new char[strlen(temp.name)+strlen(n)+2];
strcat(temp.name," ");
strcat(temp.name,n);
return temp;
}

student operator+(char *n,student s)
{
student temp(s);
delete(temp.name);
temp.name=new char[strlen(temp.name)+strlen(n)+2];
strcpy(temp.name,n);
strcat(temp.name," ");
strcat(temp.name,s.name);
return temp;
}

student::operator char*()
{return name;}
student::operator int()
{return id;}

student student::operator++()
{
grade++;
return *this;
}
student student::operator++(int d)
{
return(*this+1);
}
int student::operator==(student s)
{
return((id==s.id)&&(grade==s.grade)&&(!strcmp(name,s.name)));

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
