#include <stdio.h>
#include <conio.h>
int main ()
{
int x[5],i,max,min;
//take input from use
for(i=0;i<5;i++)
{
printf("Enter %d Number:",i+1);
scanf("%d",&x[i]);
}
max=min=x[0];
for(i=1;i<5;i++)
{
if(x[i]>max)
{
max=x[i];
}
if(x[i]<min)
{
min=x[i];
}
}
printf("The Maximum Number is %d\n",max);
printf("The Minimum Number is %d",min);
getch();
clrscr();
return 0;
}