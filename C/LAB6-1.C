#include <stdio.h>
#include <conio.h>
#include <string.h>
#include <alloc.h>
#include <ctype.h>

int main (){
int i;
char size,col=1,ch;
char*ptr,*p1;
printf("Please enter the size of the string=");
scanf("%d",&size);
ptr=(malloc(size));    //memory allocation
p1=ptr;
if(ptr!=NULL)          //condition for allocation
{
for(i=0;i<size+1;i++)     //intialize the array by NULL
{
*(ptr+i)='\0';
}
do
{
ch=getch();

//printable chars
if(isprint(ch))
{
if(p1<ptr+(size)){    // defining the array limits by size
printf("%c",ch);
*p1=ch;
col++;
p1++;}
}


switch(ch)
{
case 0:
ch=getch();
switch (ch)
				{
//left arrow  <--
case 75:
if(p1>ptr){
col--;
gotoxy(col,2);
p1--;}
break;

//right arrow  -->
case 77:
if(p1<(ptr+strlen(ptr))){    // defining end of the line
col++;
gotoxy(col,2);
p1++;}
break;                        //going to the first char
//Home
case 71:
col=1;
gotoxy(col,2);
p1=ptr;
break;
//End
case 79:
p1=ptr+(strlen(ptr)-1);  // going to the last char
col=strlen(ptr);
gotoxy(col,2);
break;
}
break;                         //printing the array content and its length
//Enter
case 13:
gotoxy(1,5);
printf("The Array Content Is= %s\n",ptr);
printf("The Array Length is= %d",strlen(ptr));
gotoxy(col,2);
break;

	}
		}
//esc condition
while(ch!=27);
   }
   clrscr();
   free(ptr);
return 0;
}