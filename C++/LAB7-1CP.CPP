#include <iostream.h>
#include <conio.h>
#include <fstream.h>
#include <string.h>
class Student
{
int id;
char name[20];
public:
Student(){id=0;strcpy(name,"N/A");}
Student(int d,char n[]){id=d;strcpy(name,n);}
void setid(int a){id=a;}
void setname(char n[]){strcpy(name,n);}
int getid(){return id;}
char* getname(){return name;}
friend ostream& operator<<(ostream& out,Student s);
friend istream& operator>>(istream& in,Student& s);
};
ostream& operator<<(ostream& out,Student s)
{
out<<"ID="<<s.id<<endl;
out<<"Name="<<s.name<<endl;
return out;
}
istream& operator>>(istream& in,Student& s)
{
in>>s.id;
in>>s.name;
return in;
}
int main()
{
  Student s1;
  Student s2;
  Student s3;
  cout<<"--Data into s1--"<<endl;
  cin>>s1;
  fstream obj;
  obj.open("Data.txt",ios::out);
  obj<<s1;                       //writing into Data.txt
  obj.close();
  obj.open("GETDATA.txt",ios::in);
  obj>>s2;
  cout<<"--Reading Data from file into s2--"<<endl;                       //reading from GETDATA.txt
  cout<<s2<<endl;
  obj.close();
  obj.open("BinaryData.dat",ios::out|ios::binary);
  obj.write((char*)&s1,sizeof(Student));       //binary writing into BinaryData.dat
  obj.close();
  obj.open("BinaryData.dat",ios::in|ios::binary);
  obj.read((char*)&s3,sizeof(Student));        //binary reading from BinaryData.dat
  obj.close();
  cout<<"--Binary Copying s1 to s3--"<<endl;
  cout<<s3<<endl;


  



getch();
clrscr();
return 0;
}