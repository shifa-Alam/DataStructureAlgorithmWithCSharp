

int LinearSearch(int[] A,int x,int n)
{
    int i;
    for ( i = 0; i < n; i++)
    {
        if (A[i] == x) return i;
    }
    i = -1;
    return i;
}
int[] aa = { 1, 4, 5, 7, 9 };
var x = LinearSearch(aa, 67, 5);
Console.WriteLine(x);
