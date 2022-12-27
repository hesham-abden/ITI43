#include <stdio.h>
#include <conio.h>
int main(){
/*char ch;
ch=getch();
if(ch==0)
{
ch=getch();
printf("\n%d",ch);
}
else
{
printf("%d",ch);
}*/
int ch,row,col;
printf("File\n");
printf("Edit\n");
printf("Print\n");
printf("Exit\n");
row=col=1;
gotoxy(row,col);
do  {
ch=getch();
switch (ch) {
case 72 :
if(row!=1){
row--;
gotoxy(col,row);
}
break;
case 80 :
if(row!=4){
row++;
gotoxy(col,row);}
break;
case 79 :
row=4;
gotoxy(4,row);
break;
case 71:
row=1;
gotoxy(1,row);
break;
case 13:
switch (row)
{
case 1:
gotoxy(10,row);
printf("File is Pressed");
row=col=1;
gotoxy(col,row);
break;
case 2:
gotoxy(10,row);
printf("Edit Is Pressed");
row=col=1;
gotoxy(col,row);
break;
case 3:
gotoxy(10,row);
printf("Print Is Pressed");
row=col=1;
gotoxy(col,row);
break;
case 4:
ch=27;
break;
}
case 27:
break;
}
}
while (ch!=27);


getch();
clrscr();
return 0;
}
