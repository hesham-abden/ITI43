#include <stdio.h>
#include <conio.h>
#include <math.h>
int main (){
int a,b,c,z;
double x1,x2;
printf("Enter a : ");
scanf("%d",&a);
printf("Enter b : ");
scanf("%d",&b);
printf("Enter c : ");
scanf("%d",&c);
z=((b*b)-4*a*c);
printf("temp=%d\n",z);
if((z)>0)
{
x1=(-1*b+sqrt(z))/(2*a);
printf ("x1 = %f\n",x1);
x2=(-1*b-sqrt(z))/(2*a);
printf ("x2 = %f\n",x2);
		  }
if(z<0){
printf("complex number");
}
if(z==0){
x1=x2=(-1*b+sqrt(z))/(2*a);
printf ("x1 = %f\n",x1);
printf ("x2 = %f",x2);
}
getch();
clrscr();

return 0;
}