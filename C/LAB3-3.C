#include <stdio.h>
#include <conio.h>
int main()
{
int i,num,row,col,size;
printf("Enter the size\"MUST BE ODD\"" );
scanf("%d",&size);
while(size%2==0 ||size==1){
printf("MUST BE ODD");
printf("Enter the size\"MUST BE ODD\"" );
scanf("%d",&size);
}
printf("Enter First Number");
scanf("%d",&num);
clrscr();
row=1;col=(size/2)+1;
gotoxy(col00*5,row*5);
printf("%d",num);
for(i=num;i<=(size*size)-2+num;)
{

if(i%size==0)

	{
   if(row!=size){row++;}
   else {row=1;}

	}
if(i%size!=0)
{
row--;
col--;
if(row<1)
{
row+=size;
}
if(col<1)
{
col+=size;
}
}
gotoxy(col*5,row*5);
i++;
printf("%d",i);

}


getch();
clrscr();
return 0;
}



