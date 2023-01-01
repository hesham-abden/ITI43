#include<stdio.h>
#include<conio.h>
int main()
{
    int i,size,j;
    printf("Enter the size of the pyramid");
    scanf("%d",&size);
    for(i=0;i<size+1;i++)
    {

        for (j = 0; j < i; j++)
        {
            printf("*");
        }
        printf("\n");


    }
    getch();
}