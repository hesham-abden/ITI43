#include <stdio.h>
#include <conio.h>
#include <alloc.h>
struct student
{
int id;
char name[20];
int grade[3];
};
int size;
struct student  fillstudent (void);
void printstudent(struct student s);
int main (){
int i;
struct student *ptr;
printf("Enter the number of students :");
scanf("%d",&size);
ptr=(struct student*)malloc(sizeof(struct student)*size);
for (i=0;i<size;i++){
ptr[i]=fillstudent();
}
for (i=0;i<size;i++)
{
printstudent(ptr[i]);
}
	 getch();
	 clrscr();
	 return 0;
	 }
struct student fillstudent(void)
{
int i;
struct student s;
printf("Enter Student ID: ");
scanf("%d",&s.id);
printf("Enter Student Name: ");
scanf("%s",s.name);
for (i=0;i<size;i++)
{
printf("Enter Student Grade for Subject No.%d:  ",i+1);
scanf("%d",&s.grade[i]);
}
return s;
}
void printstudent(struct student s)
{
int i;
printf("ID=%d\n",s.id);
printf("Name=%s\n",s.name);
for(i=0;i<size;i++){
printf("Grade No.1=%d\n",s.grade[i]);
}
}