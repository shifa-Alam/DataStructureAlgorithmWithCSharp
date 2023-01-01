void InsertionSort(int[] a)
{
    int i, j, item;
    for(i = 1; i < a.Length; i++)
    {
        item = a[i];
        j = i - 1;
        while(j >= 0 && a[j] > item)
        {
            a[j + 1] = a[j];
            j = j - 1;
        }
        a[j + 1] = item;
    }

    for(i = 0; i < a.Length; i++)
    {
        Console.Write(a[i] +" ");
    }
}
int[] x = { 5,4,2,3,1 };
InsertionSort(x);