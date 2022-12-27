#include <stdio.h>
#include <conio.h>
void draw_menu(void);
int add(int x,int y);
int sub(int x,int y );
float div(float x,float y);
int multi(int x,int y);
int main() {
int row,col,x,y,flag=0;
char ch;;
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
row=5;
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
case 1:
gotoxy(1,8);
printf("Enter First Number: ");
scanf("%d",&x);
printf("Enter Second Number: ");
scanf("%d",&y);
printf("Result= %d\n",add(x,y));
printf("Press Any Key to Continue");
getch();
clrscr();
draw_menu();
row=col=1;
gotoxy(col,row);
break;
case 2:
gotoxy(1,8);
printf("Enter First Number: \t");
scanf("%d",&x);
printf("Enter Second Number: \t");
scanf("%d",&y);
printf("Result= %d\n",sub(x,y));
printf("Press Any Key to Continue");
getch();
clrscr();
draw_menu();
row=col=1;
gotoxy(col,row);
break;
case 3:
gotoxy(1,8);
printf("Enter First Number:  ");
scanf("%d",&x);
printf("Enter Second Number:");
scanf("%d",&y);
printf("Result= %d\n",multi(x,y));
printf("Press Any Key to Continue");
getch();
clrscr();
draw_menu();
row=col=1;
gotoxy(col,row);
break;
case 4:
gotoxy(1,8);
printf("Enter First Number:");
scanf("%d",&x);
printf("Enter Second Number:");
scanf("%d",&y);
printf("Result= %f\n",div(x,y));
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
void draw_menu(void)
{
printf("Add\n");
printf("Subtract\n");
printf("Mulitply\n");
printf("Divide\n");
printf("Exit");
}
int add(int x,int y)
{
return x+y;
}
int sub(int x,int y)
{
return x-y;
}
int multi(int x,int y)
{
return x*y;
}
float div(float x,float y)
{
float z=x/y;
return z;
}
