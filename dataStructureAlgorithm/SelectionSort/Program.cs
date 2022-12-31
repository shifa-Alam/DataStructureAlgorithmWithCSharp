void SelectionSort(int[]a, int n)
{
    int i, j, minIndex;

    for (i = 0; i < n; i++)
    {
        minIndex = i;

        for (j = i+1; j < n; j++)
        {
            if(a[j] < a[minIndex])
            {

                minIndex=j;
            }
            
        }
        if (minIndex != i)
        {
            int temp = a[i];
            a[i] = a[minIndex];
            a[minIndex] = temp;

        }
        Console.Write(a[i] + " ");
    }
    
}
int[] b = { 1, 10, 3, 32, 5 };
SelectionSort(b, 5);