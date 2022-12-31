
void BubbleSort(int[]a,int n)
{
    int i, j, temp;
    for (i = 0; i < n; i++)
    {
        for (j = 0; j < n-i-1; j++)
        {
            if (a[j] > a[j + 1])
            {
                temp = a[j];    
                a[j] = a[j + 1];
                a[j + 1] = temp;

            }
        }
    }
    for(int k=0; k < n; k++)
    {
        Console.Write(a[k]+" ");
    }
}

int[] x = { 90, 10, 32, 1, 2, 79 };
BubbleSort(x, 6);
