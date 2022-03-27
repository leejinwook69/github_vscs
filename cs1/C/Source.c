#include <stdio.h>

int arr[500001];
int first[500001];
int second[500001];
int third[500001];

int main(void)
{
    int n, state, checkOn;
    scanf("%d", &n);

    for (int i = 1; i <= n; i++)
    {
        scanf("%d", &first[i]);
    }
    for (int i = 1; i <= n; i++)
    {
        scanf("%d", &second[i]);
    }
    for (int i = 1; i <= n; i++)
    {
        scanf("%d", &third[i]);
    }


    for (int pivot = 1; pivot <= n; pivot++)
    {
        if (arr[pivot] == -1) { continue; }



        checkOn = 0;
        for (int i = 1; i <= n; i++)
        {
            if (arr[i] == -1) { continue; }

            if (checkOn == 1)
            {
                arr[i]++;
            }
            if (first[i] == pivot)
            {
                checkOn = 1;
            }
        }
        for (int i = 1; i <= n; i++)
        {
            if (arr[i] == -1) { continue; }

            if (arr[i] == 3)
            {
                arr[i] = -1;
                printf("pivot %d : first trial, -1 = %d\n", pivot, i);
            }
            else
            {
                arr[i] = 0;
            }
        }



        checkOn = 0;
        for (int i = 1; i <= n; i++)
        {
            if (arr[i] == -1) { continue; }

            if (checkOn == 1)
            {
                arr[i]++;
            }
            if (second[i] == pivot)
            {
                checkOn = 1;
            }
        }
        for (int i = 1; i <= n; i++)
        {
            if (arr[i] == -1) { continue; }

            if (arr[i] == 3)
            {
                arr[i] = -1;
                printf("pivot %d : second trial, -1 = %d\n", pivot, i);
            }
            else
            {
                arr[i] = 0;
            }
        }



        checkOn = 0;
        for (int i = 1; i <= n; i++)
        {
            if (arr[i] == -1) { continue; }

            if (checkOn == 1)
            {
                arr[i]++;
            }
            if (third[i] == pivot)
            {
                checkOn = 1;
            }
        }
        for (int i = 1; i <= n; i++)
        {
            if (arr[i] == -1) { continue; }

            if (arr[i] == 3)
            {
                arr[i] = -1;
                printf("pivot %d : third trial, -1 = %d\n", pivot, i);
            }
            else
            {
                arr[i] = 0;
            }
        }

    }


    return 0;
}