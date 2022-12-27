struct student{

int id;
char name[10];
};
int main (){
struct student arr[5];
int i,j,temp,s=5;
for(i=0;i<5;i++)
{
printf("Enter ID:\n");
scanf("%d",&(arr[i].id));
}

for(i=0;i<s-1;i++)
{

for(j=0;j<s-1-i;j++){
if((arr[j].id)>(arr[j+1].id))
{
temp=arr[j].id;
arr[j].id=arr[j+1].id;
arr[j+1].id=temp;
}
}
}
for(i=0;i<5;i++)
{
printf("%d,",arr[i].id);
}

