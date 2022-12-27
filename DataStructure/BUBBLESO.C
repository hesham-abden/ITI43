#include <stdio.h>
#include <conio.h>



int main(){
int i,j,temp,sort=1,c=0,s=10;
int arr[10]={10,9,8,7,6,5,12,78,1,8};
for(i=0;(i<s-1)&&(sort==1);i++)
{
sort=0;
for(j=0;j<s-i-1;j++)
{
if(arr[j]>arr[j+1])
{
temp=arr[j];
arr[j]=arr[j+1];
arr[j+1]=temp;
sort=1;
}
} }
for(i=0;i<s-1;i++)
printf("%d,",arr[i]);
printf("\n %d",c);



getch();
clrscr();
return 0;
}