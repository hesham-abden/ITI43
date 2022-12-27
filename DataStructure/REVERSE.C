#include <stdio.h>
#include <conio.h>
#include <alloc.h>

struct node
{
int d;
struct node *next;
};
void create(struct node **ptr,int d);
int  count(struct node **ptr,int d);
void sort(struct node **ptr);
void reverse(struct node **ptr);
void print(struct node**ptr);
int main(void){
struct node *head=NULL;
struct node *temp;
//int i=0;
free(head);
create(&head,1);
create(&head,2);
create(&head,3);
create(&head,4);
create(&head,5);
create(&head,6);
create(&head,7);
//sort(&head);
print(&head);

//temp=head;
/*for(i=0;i<7;i++)
{
printf("%d\t",temp->d);
temp=temp->next;
}
printf("\n");
reverse(&head);
temp=head;
for(i=0;i<7;i++)
{
printf("%d\t",temp->d);
temp=temp->next;
} */

getch();
clrscr();
return 0;
}
void create(struct node **ptr,int d){

struct node *temp;
temp=(struct node *)malloc(sizeof(struct node));
if(temp)
{
temp->d=d;
temp->next=*ptr;
*ptr=temp;
}
}
int count (struct node**ptr,int d){
int count=0;
while((*ptr)->next!=NULL)
{
if(((*ptr)->d)==d)
{
count++;
}
(*ptr)=(*ptr)->next;
}
return count;
}
void sort(struct node **ptr){
int temp,s=1;
struct node *node;
while(s)
{
node=*ptr;
s=0;
while(node->next)
	{
if(node->d < node->next->d)
	{
	temp=node->d;
	node->d=node->next->d;
	node->next->d=temp;
	s=1;
	}
	node=node->next;
	}

}
}
void reverse (struct node**ptr)
{
struct node *ptr1,*ptr2;
int temp=0,count=0,i,j;
ptr1=ptr2=*ptr;
while((ptr2->next)!=NULL)
{
ptr2=ptr2->next;
count++;
}
ptr2->next=ptr1;
for(i=0;i<(count/2);i++)
{
temp=ptr1->d;
ptr1->d=ptr2->d;
ptr2->d=temp;
for(j=0;j<count;j++)
ptr2=ptr2->next;
ptr1=ptr1->next;
}

}
 void print(struct node **ptr)
 {
 struct node *temp;
	temp=*ptr;
	if(temp->next)
	{
	print((&temp->next));
	}
	printf("%d\t",temp->d);

 }