#include <stdio.h>
#include <conio.h>
#include <string.h>
int main()
{
char first_name[15],second_name[15],full_name[31],compare;
printf("Enter First Name:"); //maximum letters is 14
scanf("%s",first_name);
printf("Enter Second Name:"); //maximum letter is 14
scanf("%s",second_name);
strcpy(full_name,first_name);
strcat(full_name," ");
strcat(full_name,second_name);
printf("Last Name: %s\n",full_name);
compare=strcmp(first_name,second_name);
printf("Duplication=%d",compare);

getch();
clrscr();
return 0;
}