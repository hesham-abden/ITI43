#include <stdio.h>
#include <conio.h>
#include <alloc.h>
struct node{
int id;
//struct node*pNext;
struct node*pPrev;
};
struct node* pTail;
int Push(int d);
struct node* Pop(void);
int PrintStack(void);
 void draw_menu(void);
int main(){
int x,i,col,row,flag=0,check;
char ch;
struct node*ptr,*s;
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
if(row!=5){
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
case 1:       // Push Node
gotoxy(1,12);
printf("ID:");
scanf("%d",&x);
check=Push(x);
if(check){
printf("DONE !\n");
}
printf("Press Any Key to Continue");
getch();
clrscr();
draw_menu();
row=col=1;
gotoxy(col,row);
break;
case 2:   //Pop Node
gotoxy(1,12);
s=Pop();
if(s){
printf("ID=%d :",s->id);
free(s);
}
else printf("Empty Stack\n");
printf("Press Any Key to Continue");
getch();
clrscr();
draw_menu();
row=col=1;
gotoxy(col,row);
break;
case 3:   	//update node
gotoxy(1,12);
x=PrintStack();
if(!x)
printf("Empty Stack\n");
printf("DONE !\n");
printf("Press Any Key to Continue");
getch();
clrscr();
draw_menu();
row=col=1;
gotoxy(col,row);
break;
case 4:
flag=1;
break;
}
case 27:
break;
}
}
while (ch!=27&&flag==0);
clrscr();
free(s);
return 0;
}

int Push(int d){
struct node* ptr;
int ret=0;
ptr=(struct node*)malloc(sizeof(struct node*));
if(ptr){
ret=1;
ptr->id=d;
if(pTail)
{
ptr->pPrev=pTail;
pTail=ptr;
}
else
{
pTail=ptr;
pTail->pPrev=NULL;
}}
return ret;
}
struct node* Pop(void){
struct node* ptr;
ptr=(struct node*)malloc(sizeof(struct node*));
ptr=pTail;
if(ptr)
	{
	pTail=pTail->pPrev;
	}
	else{
	     ptr=NULL;
	     }
	return ptr;
	}

int PrintStack(void){
struct node*ptr;
int ret=0;
ptr=(struct node*)malloc(sizeof(struct node*));
ptr=pTail;
if(ptr)
{
ret=1;
while (ptr){
printf("%d\n",ptr->id);
ptr=ptr->pPrev;
}
}
return ret;
}


 void draw_menu(void)
{
printf("Push Node\n");
printf("Pop Node\n");
printf("Print Stack\n");
printf("Exit");
}
