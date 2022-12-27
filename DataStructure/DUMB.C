#include <stdio.h>
#include <conio.h>
#include <alloc.h>
#include <string.h>
struct node {
int ID;
struct node *pPrev;
struct node *pNext;
};
struct  node *pHead;
struct 	node *pTail;
struct 	node* createnode(void);
int addnode(void);
int reverse(struct node*ptr);


 int main()
 {

  getch();
  clrscr();
  return 0;

 }











struct node* createnode(){
struct node *ptr;
int d;
ptr=(struct node*)malloc(sizeof(struct node));
if(ptr){
printf("Enter ID:");
scanf("%d",&d);
ptr->ID=d;
ptr->pNext=ptr->pPrev=NULL;}
return ptr;
}
int addnode(){
int ret=0;
struct node*ptr;
ptr=createnode();
if(ptr)
{
ret=1;
if(pHead==NULL){
pHead=pTail=ptr;
}
else{
pTail->pNext=ptr;
ptr->pPrev=pTail;
pTail=ptr;}}
return ret;
}
int reverse(struct node*ptr)
{
struct node *prev;
struct node temp;
int ret=0;
prev=NULL;
ptr=pHead;

while (ptr&& (ptr!=prev))
{
while((ptr->pNext)&&((ptr->pNext)!=prev))
{
ret=1;
temp.ID=ptr->ID;
ptr->ID=(ptr->pNext)->ID;
(ptr->pNext)->ID=temp.ID;
ptr=ptr->pNext;
}
prev=ptr;
ptr=pHead;
}
return ret;
}
