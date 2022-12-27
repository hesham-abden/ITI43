#include <stdio.h>
#include <conio.h>
int main(){
int x[4][3],i,j,sum[4]={0};
float avg[3]={0};

for (i=0;i<4;i++)
{for (j=0;j<3;j++)
{
printf("Student:%d\t,Subject:%d\t",i+1,j+1);
scanf("%d",&x[i][j]);
}}
for(i=0;i<4;i++)
{for(j=0;j<3;j++)
{
sum[i]=sum[i]+x[i][j];
avg[j]=avg[j]+x[i][j];
}
}
/*for(j=0;j<3;j++)
{for(i=0;i<4;i++)
{
avg[j]=avg[j]+x[i][j];
}}*/

printf("First Student Marks =%d\n",sum[0]);
printf("Second Student Marks =%d\n",sum[1]);
printf("Third Student Marks =%d\n",sum[2]);
printf("The Avg for First Subject= %f\n",avg[0]/i);
printf("The Avg for Second Subject= %f\n",avg[1]/i);
printf("The Avg for Third Subject= %f",avg[2]/i);
getch();
clrscr();
return 0;
}
