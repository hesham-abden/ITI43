#include <stdio.h>
#include <conio.h>
#include <string.h>
void Merge(int low,int mid, int high);
void Merge_Sort(int lb,int ub);

struct student{

int id;
char name[10];
};
struct student arr[5];
int s=0;
int main(){

arr[0].id=8;
strcpy(arr[0].name,"A");
arr[1].id=10;
strcpy(arr[1].name,"A");
arr[2].id=20;
strcpy(arr[2].name,"A");
arr[3].id=1;
strcpy(arr[3].name,"A");
arr[4].id=7;
strcpy(arr[4].name,"A");
Merge_Sort(0,s);

}









void Merge_Sort(lb,ub){
int mid;
if(lb>ub)
{
mid=(lb+ub)/2;
Merge_Sort(lb,mid);
Merge_Sort(mid+1,ub);
Merge(lb,mid,ub);
}
}





void Merge(low,mid,high){

struct student temp[5],copy[5];
 int i=low;
int j;
int list1=low,list2=mid+1;
while(list1<mid&&list2<high)
{
if(arr[list1].id>=arr[list2].id)
{
temp[i]=arr[list2];
i++;
list1++;
}
else
{
temp[i]=arr[list1];
i++;
list2++;
}
}
if(list1>mid)
{
for(j=i;j<high;j++)
{
temp[i]=arr[list2];
list2++;
}
}
if(list2<high){
for(j=i;j<mid;j++)
{
temp[i]=arr[list1];
list2++;
}

for(j=low;j<=high;j++)
{
arr[i]=temp[i];


}}}