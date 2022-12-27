#include <stdio.h>
#include <conio.h>
float power(int x,int y);
int main(){
int x,y;
printf("Enter Base:");
scanf("%d",&x);
printf("Enter Power:");
scanf("%d",&y);
printf("Result=%f",power(x,y));
getch();
clrscr();
return 0;
}
float power(int x,int y)
{
if(x!=0){
if(y>0)
{
return x*power(x,(y-1));
//return result;
}
if(y<0)
{
return 1/(power(x,-1*(y)));
//return result;
}
}
return 1;
}
