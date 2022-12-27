#include<stdio.h>
#include<conio.h>
int main()
{
	int FirstNum;
	int SecondNum;
	int Result;
	printf("Enter your first number\n");
	scanf("%d",&FirstNum);
	printf("Enter your second number\n");
	scanf("%d",&SecondNum);
	Result = FirstNum + SecondNum;
	printf("The result is : ", Result);
	getch();
        
	return 0;
}