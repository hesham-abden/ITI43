#include <stdio.h>
#include <conio.h>
#include <alloc.h>
#include <string.h>
struct node {
int ID;
char name[10];
struct node *pPrev;
struct node *pNext;
};
struct  node *pHead;
struct 	node *pTail;
struct 	node* createnode(void);
int addnode(void);
int insertnode(int loc);
struct node * searchnode(int d);
struct node * searchnode_name(void);
int deletenodebyloc(int loc);
int deletenode(int d);
void freelist(void);
void updatenode(int d,int x);
 void draw_menu(void);
void printlist(void);


int main(){
struct node*temp,*a;
int test,i;
int row,col,u,d,flag=0,loc,m;
char ch;
draw_menu();
row=col=1;
gotoxy(row,col);
do  {
ch=getch();
switch (ch) {
case 0:
ch=getch();
switch (ch) {
case 72 :
if(row!=1){
row--;
gotoxy(col,row);
}
break;
case 80 :
if(row!=10){
row++;
gotoxy(col,row);}
break;
case 79 :
row=9;
gotoxy(1,row);
break;
case 71:
row=1;
gotoxy(1,row);
break;
}  break;
case 13:
switch (row)
{
case 1:       // add node
gotoxy(1,12);
m=addnode();
if(a){
printf("DONE !\n");
}
printf("Press Any Key to Continue");
getch();
clrscr();
draw_menu();
row=col=1;
gotoxy(col,row);
break;
case 2:   //insert node
gotoxy(1,12);
printf("Location :");
scanf("%d",&loc);
m=insertnode(loc);
if(m){
printf("DONE !\n");
}
printf("Press Any Key to Continue");
getch();
clrscr();
draw_menu();
row=col=1;
gotoxy(col,row);
break;
case 3:   	//update node
gotoxy(1,12);
printf("Enter ID : ");
scanf("%d\n",&d);
printf("Enter New ID : ");
scanf("%d\n",&u);
updatenode(d,u);
printf("DONE !\n");
printf("Press Any Key to Continue");
getch();
clrscr();
draw_menu();
row=col=1;
gotoxy(col,row);
break;
case 4:
gotoxy(1,12);
printlist();
printf("Press Any Key to Continue");
getch();
clrscr();
draw_menu();
row=col=1;
gotoxy(col,row);
break;
case 5:   	//search node by id
gotoxy(1,12);
printf("Enter ID  : ");
scanf("%d",&d);
temp=searchnode(d);
printf("ID:%d,Name:%s\n",temp->ID,temp->name);
printf("DONE !\n");
printf("Press Any Key to Continue");
getch();
clrscr();
draw_menu();
row=col=1;
gotoxy(col,row);
break;
case 6:   	//search node by name
gotoxy(1,12);
temp=searchnode_name();
printf("ID:%d,Name:%s\n",temp->ID,temp->name);
printf("DONE !\n");
printf("Press Any Key to Continue");
getch();
clrscr();
draw_menu();
row=col=1;
gotoxy(col,row);
break;
case 7:   	//delete node by location
gotoxy(1,12);
printf("Enter Location  : ");
scanf("%d",&loc);
test=deletenodebyloc(loc);
if(test){
printf("DONE !\n"); }
else{
printf("FAIL  !\n");
}
printf("Press Any Key to Continue");
getch();
clrscr();
draw_menu();
row=col=1;
gotoxy(col,row);
break;
case 8:   	//delete node by location
gotoxy(1,12);
printf("Enter ID :");
scanf("%d",&d);
test=deletenode(d);
if(test){
printf("DONE !\n"); }
else{
printf("FAIL  !\n");
}
printf("Press Any Key to Continue");
getch();
clrscr();
draw_menu();
row=col=1;
gotoxy(col,row);
break;
case 9:
freelist();
gotoxy(1,12);
printf("DONE !\n");
printf("Press Any Key to Continue");
getch();
clrscr();
draw_menu();
row=col=1;
gotoxy(col,row);
break;
case 10:
flag=1;
break;
}
case 27:
break;
}
}
while (ch!=27&&flag==0);
clrscr();
return 0;
}
struct node* createnode(){
struct node *ptr;
int d; char name[20];
ptr=(struct node*)malloc(sizeof(struct node));
if(ptr){
printf("Enter ID:");
scanf("%d",&d);

printf("Enter Name:");
scanf("%s",name);
ptr->ID=d;
strcpy(ptr->name,name);
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

struct node* searchnode(int d){
struct node* ptr;
ptr=pHead;
while(((ptr->ID)!=d))
{
ptr=ptr->pNext;
}
return ptr;
}

void freelist(){
struct node* ptr;
while(pHead!=NULL){
ptr=pHead;
pHead=pHead->pNext;
free(ptr);}
}
int insertnode(int loc){
struct node *ptr,*temp; int ret=0; int i;
ptr=createnode();
if(ptr){
ret=1;
if(pHead==NULL)
{
pHead=pTail=ptr;
ptr->pNext=ptr->pPrev=NULL;
}
else
{ if(loc==0){
	     ptr->pNext=pHead;
	     pHead->pPrev=ptr;
	     pHead=ptr;
	     }
	     else
	     {
	     temp=pHead;
	     for(i=0;i<loc-1;i++)
		{
		temp=temp->pNext;
		}
		if(temp->pNext==NULL||temp==NULL)
		{
		ptr->pPrev=pTail;
		pTail->pNext=ptr;
		pTail=ptr;
		}
		else
		{
		(temp->pNext)->pPrev=ptr;
		ptr->pNext=temp->pNext;
		ptr->pPrev=temp;
		temp->pNext=ptr;
		}}}}
		return ret; }


int deletenodebyloc(int loc){
int i,ret=0;
struct node*temp;
temp=pHead;
if(loc==0){
(pHead->pNext)->pPrev=NULL;
pHead=pHead->pNext;
free(temp);
ret=1;

}
else
	{
	for(i=0;i<loc;i++)
	temp=temp->pNext;

	if(temp->pNext==NULL||temp==NULL)
	{
	(pTail->pPrev)->pNext=NULL;
	pTail=pTail->pPrev;
	free(temp);
	ret=1;
	}
	else
	{
	 (temp->pPrev)->pNext=temp->pNext;
	 (temp->pNext)->pPrev=temp->pPrev;
	 free(temp);
	 ret=1;
	 }} return ret;}

  int deletenode(d){
       struct node*temp;
       int ret=0;
       temp=searchnode(d);
       if(temp->pPrev==NULL)
       { 	(pHead->pNext)->pPrev=NULL;
		pHead=pHead->pNext;
		free(temp);
		ret=1;
		}
       else {
		if(temp->pNext==NULL||temp==NULL)
	{
	(pTail->pPrev)->pNext=NULL;
	pTail=pTail->pPrev;
	free(temp);
	ret=1;
	}
	else
	{
	 (temp->pPrev)->pNext=temp->pNext;
	 (temp->pNext)->pPrev=temp->pPrev;
	 free(temp);
	 ret=1;
	 }}	return ret;

  }
struct node * searchnode_name(){
struct node*temp;
char arr[20];
temp=pHead;
printf("Enter Name: ");
scanf("%s",arr);
while(temp!=NULL){
if(!strcmp(arr,temp->name))

			{
			printf("\nName Found !\n");
			break;}
			else{
temp=temp->pNext;}
}
return temp;
}


void updatenode(int d,int x)
{   struct node *temp;
temp=searchnode(d);
temp->ID=x;
}

 void draw_menu(void)
{
printf("Add Node\n");
printf("Insert Node\n");
printf("Update Node\n");
printf("Print List\n");
printf("Search Node by ID\n");
printf("Search Node by name\n");
printf("Delete Node by location\n");
printf("Delete Node by ID\n");
printf("Free List\n");
printf("Exit");
}

void printlist(void){
	struct node*ptr;
	ptr=pHead;
if(ptr==NULL)
{
printf(" NO LIST !");}
else{
while(ptr){
printf("(ID:%d,Name:%s)\t",ptr->ID,ptr->name);
ptr=ptr->pNext;  }}
printf("\n");
}
