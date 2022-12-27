#include <stdio.h>
#include <conio.h>
#include <alloc.h>


struct student{
int id;
struct student *pLeft;
struct student *pRight;
};
struct student *node;
struct student * Create_node(int d);
struct student * Insert_node(struct student *ptr,int d);
struct student * Preorder(struct student  *ptr);
struct student * Postorder(struct student  *ptr);
struct student * Inorder(struct student  *ptr);
void Display(struct student *ptr,int x,int y);
void draw_menu(void);

int main(){








struct student *temp;
int x,col,row,flag=0;
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
if(row!=6){
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
case 1:       // Add Student
gotoxy(1,12);
printf("ID:");
scanf("%d",&x);
node=Insert_node(node,x);
if(node){
printf("DONE !\n");}
else
printf("FULL!");
printf("Press Any Key to Continue");
getch();
clrscr();
draw_menu();
row=col=1;
gotoxy(col,row);
break;
case 2:   //Display
gotoxy(1,12);
Display(node,20,20);
printf("\nDone!");
printf("Press Any Key to Continue");
getch();
clrscr();
draw_menu();
row=col=1;
gotoxy(col,row);
break;
case 3:   	//InOrder
gotoxy(1,12);
temp=Inorder(node);
printf("DONE !\n");
printf("Press Any Key to Continue");
getch();
clrscr();
draw_menu();
row=col=1;
gotoxy(col,row);
break;
case 4:   //PreOrder
gotoxy(1,12);
temp=Preorder(node);
printf("Done!");
printf("Press Any Key to Continue");
getch();
clrscr();
draw_menu();
row=col=1;
gotoxy(col,row);
break;
case 5:   //PostOrder
gotoxy(1,12);
temp=Postorder(node);
printf("Done!");
printf("Press Any Key to Continue");
getch();
clrscr();
draw_menu();
row=col=1;
gotoxy(col,row);
break;
case 6:
flag=1;
break;
}
case 27:
break;
}
}
while (ch!=27&&flag==0);

















getch();
clrscr();
return 0;

}

struct student* Create_node(int d)
{
struct student *ptr;
ptr=(struct student *)malloc(sizeof(struct student));
if(ptr)
{  ptr->id=d;
	ptr->pLeft=ptr->pRight=NULL;

}
return ptr;
}

struct student * Insert_node(struct student *ptr,int d)
{
if(ptr==NULL)
{ ptr=Create_node(d);
}
else
{
if(ptr->id > d)
{
ptr->pLeft=Insert_node(ptr->pLeft,d);
}
if(ptr->id <=d)
{
ptr->pRight=Insert_node(ptr->pRight,d);
}}
return ptr;
 }
struct student * Preorder(struct student  *ptr){
if(ptr!=NULL)
{
struct student *temp;
printf("%d\n",ptr->id);
temp=Preorder(ptr->pLeft);
temp=Preorder(ptr->pRight);
}
return ptr;
}

struct student * Postorder(struct student  *ptr)
{
if(ptr!=NULL)
{
struct student *temp;
temp=Preorder(ptr->pLeft);
temp=Preorder(ptr->pRight);
printf("%d\n",ptr->id);
}
return ptr;
}

struct student * Inorder(struct student  *ptr)
{
if(ptr!=NULL)
{
struct student *temp;
temp=Preorder(ptr->pLeft);
printf("%d\n",ptr->id);
temp=Preorder(ptr->pRight);
}
return ptr;
}
void Display(struct student *ptr,int x,int y){

struct student *temp;
temp=ptr;
gotoxy(x,y);
printf("%d",temp->id);
if((temp->pRight)!=NULL)
{
Display(temp->pRight,x+5,y+3);
}
if((temp->pLeft)!=NULL)
{
Display(temp->pLeft,x-5,y+3);
}
}
void draw_menu(void)
{
printf("1-Add Node\n");
printf("2-Display\n");
printf("3-InOrder\n");
printf("4-PreOrder\n");
printf("5-PostOrder\n");
printf("6-Exit\n");
}