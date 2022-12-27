#include <stdio.h>
#include <conio.h>
#include <string.h>


struct student{

int id;
char name[10];
};
struct student arr[5];
int s=0;
int Add_Student(int d,char name[10]);
void Print_Student(void);
void Sort(int s);
void draw_menu(void);
void Merge_Sort( int lb,int ub);
void Merge(int low,int mid,int high);
int main (){
struct student temp;


int x,i,col,row,flag=0,check;
char ch;
char name[10];
draw_menu();
row=col=1;
gotoxy(row,col);
do  {
ch=getch();
switch (ch) {
case 0:
ch=getch();
switch (ch) {
case 72 :
if(row!=1){
row--;
gotoxy(col,row);
}
break;
case 80 :
if(row!=5){
row++;
gotoxy(col,row);}
break;
case 79 :
row=9;
gotoxy(1,row);
break;
case 71:
row=1;
gotoxy(1,row);
break;
}  break;
case 13:
switch (row)
{
case 1:       // Add Student
gotoxy(1,12);
printf("ID:");
scanf("%d",&x);
printf("Name:");
scanf("%s",name);
check=Add_Student(x,name);
if(check){
printf("DONE !\n");
}
else
printf("FULL!");
printf("Press Any Key to Continue");
getch();
clrscr();
draw_menu();
row=col=1;
gotoxy(col,row);
break;
case 2:   //Bubble Sort
gotoxy(1,12);
Sort(s);
//Merge_Sort(0,s-1);
printf("Done!");
printf("Press Any Key to Continue");
getch();
clrscr();
draw_menu();
row=col=1;
gotoxy(col,row);
break;
case 3:   	//student
gotoxy(1,12);
Print_Student();
printf("DONE !\n");
printf("Press Any Key to Continue");
getch();
clrscr();
draw_menu();
row=col=1;
gotoxy(col,row);
break;
case 4:   //Bubble Sort
gotoxy(1,12);
//Sort(s);
Merge_Sort(0,s-1);
printf("Done!");
printf("Press Any Key to Continue");
getch();
clrscr();
draw_menu();
row=col=1;
gotoxy(col,row);
break;
case 5:
flag=1;
break;
}
case 27:
break;
}
}
while (ch!=27&&flag==0);





clrscr();
return 0;
}



int Add_Student(int id,char name[10]){
int test=0;
struct student temp;
if(s<5){
arr[s].id=id;
strcpy(arr[s].name,name);
s++;
test=1;
}
return test;
}
void Sort(int s)
{
struct student temp;
int i,j;
for(i=0;i<s-1;i++)
{
for(j=0;j<s-i-1;j++)
{
if(arr[j].id>arr[j+1].id)
{
temp=arr[j];
arr[j]=arr[j+1];
arr[j+1]=temp;
}
}
}
}

void Print_Student(void)
{
int i;
for(i=0;i<s;i++)
{
printf("ID:%d,Name:%s\n",arr[i].id,arr[i].name);
}
}

void draw_menu(void)
{
printf("1-Add Student\n");
printf("2-Bubble Sort\n");
printf("3-Print All\n");
printf("4-Merge Sort By Name\n");
printf("5-Exit\n");
}


void Merge_Sort(lb,ub){
int mid;
if(lb<ub)
{
mid=(lb+ub)/2;
Merge_Sort(lb,mid);
Merge_Sort(mid+1,ub);
Merge(lb,mid,ub);
}
}
void Merge(low,mid,high){
struct student temp[5];
int i=low;
int j;
int list1=low,list2=mid+1;
while(list1<=mid&&list2<=high)
{
if(strcmp(arr[list1].name,arr[list2].name)>0)
{
temp[i]=arr[list1];
i++;
list1++;
}
else
{  //if(strcmp(arr[list1].name,arr[list2].name)<0){
temp[i]=arr[list2];
i++;
list2++;
}
}
if(list1>mid)
{
while(list2<=high)
{
temp[i]=arr[list2];
list2++;
i++;}}
else
{
while(list1<=mid)
{
temp[i]=arr[list1];
list1++;
i++;
}
}
for(i=low;i<=high;i++)
{
arr[i]=temp[i];
}
}


