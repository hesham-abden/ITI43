#include <stdio.h>
#include <conio.h>
int t=-1;
int arr[5];
int Inqueue(int d);
int Dequeue(void);
int PrintQueue(void);
void draw_menu(void);
int main(){
int x,col,row,flag=0,check;
char ch;
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
case 1:       // Inqueue
gotoxy(1,12);
printf("ID:");
scanf("%d",&x);
check=Inqueue(x);
if(check){
printf("DONE !\n");
}
else printf("Full Queue\n");
printf("Press Any Key to Continue");
getch();
clrscr();
draw_menu();
row=col=1;
gotoxy(col,row);
break;
case 2:   //Dequeue
gotoxy(1,12);
x=Dequeue();
if(x!=-1){
printf("ID=%d :",x);
}
else printf("Empty Queue\n");
printf("Press Any Key to Continue");
getch();
clrscr();
draw_menu();
row=col=1;
gotoxy(col,row);
break;
case 3:   	//Print Queue
gotoxy(1,12);
x=PrintQueue();
if(!x)
printf("Empty Queue\n");
printf("DONE !\n");
printf("Press Any Key to Continue");
getch();
clrscr();
draw_menu();
row=col=1;
gotoxy(col,row);
break;
case 4:
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
int Inqueue(int d){
int ret=1;
if(t==-1){
arr[t+1]=d;
t++;
}
else{
if(t<4){
arr[t+1]=d;
t++;
}
else
{
ret=0;
}
}
return ret;
}

int Dequeue (void){
int x,i;
if(t>-1){
x=arr[0];
t--;
for(i=0;i<4;i++)
{
arr[i]=arr[i+1];
}
}
else x=-1;
return x;
}

 int PrintQueue(void){
 int i,ret=0;
 if(t!=-1){
	 ret=1;
 for(i=0;i<t+1;i++){
printf("%d\n",arr[i]); }}
else ret=0;
return ret;
}
void draw_menu(void){
printf("1->Inqueue\n");
printf("2->Dequeue\n");
printf("3-PrintQueue\n");
printf("4-Exit");
}