#include <iostream.h>
#include <string.h>
#include <conio.h>
struct student
{
  int id;
  char name[20];

};
student fillstudent(void);
void printstudent(student s);
int main()
{ student s;
int n;
student *ptr,*ptr1;
cout<<"Enter Number of Students :";
cin>>n;
ptr=new student[n+1];
ptr1=ptr;
for(int i=0;i<n;i++)
{
*ptr1=fillstudent();
ptr1++;
}
ptr1=ptr;
for(i=0;i<n;i++)
{
printstudent(*ptr1);
ptr1++;
}
delete(ptr1);

getch();
clrscr();
return 0;
}
student fillstudent(void)
{
student s;
int x;
char n[20];
cout<<"Enter ID:";
cin>>x;
cout<<"Enter Name:";
cin>>n;
s.id=x;
strcpy(s.name,n);
return s;
}
void printstudent(student s)
{
 cout<<"ID:"<<s.id<<endl;
 cout<<"Name:"<<s.name<<endl;
}

