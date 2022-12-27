#include <stdio.h>
#include <conio.h>
int main (){
int num,x,i,max=0,min=100;
printf("Enter how many numbers: ");
scanf("%d",&num);
for(i=0;i<num;i++)
{
printf("Enter The  %d num: ",1+i);
scanf("%d",&x);
if(x>max)
{
max=x;
}
if(x<min)
{
min=x;
}

}
printf("The Maximum Number is : %d\n ",max);
printf("The Minimum NUmber is : %d ",min);




getch();
clrscr();
return 0;
}