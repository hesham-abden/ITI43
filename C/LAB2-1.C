#include <stdio.h>
#include <conio.h>
int main (){

int a,b,c,d,e;
printf("Enter the first number");
scanf("%d",&a);
printf("Enter the second number");
scanf("%d",&b);
printf("Enter the third number");
scanf("%d",&c);
printf("Enter the fourth number");
scanf("%d",&d);
printf("Enter the fifth number");
scanf("%d",&e);
printf("the max number is : ");
if(a>=b&&a>=c&&a>=d&&a>=e)
{
printf("The first");
}
else if (b>=c&&b>=d&&b>e)
{
printf("the second");
}
else if (c>=d&&c>=e)
{
printf("the third");
}
else if (d>=e)
{
printf("the fourth");
}
else { printf("the fifth");}
printf("\nthe minimum number is :");

if(a<=b&&a<=c&&a<=d&&a<=e)
{
printf("The first");
}
else if (b<=c&&b<=d&&b<e)
{
printf("the second");
}
else if (c<=d&&c<=e)
{
printf("the third");
}
else if (d<=e)
{
printf("the fourth");
}
else { printf("the fifth");}



getch();
clrscr();
return 0;
}