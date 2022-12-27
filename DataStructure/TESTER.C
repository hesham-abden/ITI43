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

int main(void){
struct node *head=NULL;
struct node *temp;
int i;
free(head);
create(&head,1);
create(&head,7);
create(&head,3);
create(&head,5);
create(&head,10);
create(&head,2);
sort(&head);
temp=head;
while(temp)
{
printf("%d\n",temp->d);
temp=temp->next;
}

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