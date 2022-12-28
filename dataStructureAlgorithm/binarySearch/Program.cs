int binarySearch(int []a,int length, int searchNumber)
{
    int left=0;
    int right= length - 1;
    int mid;
    while (left<=right)
    {
        mid = (left + right) / 2;
        if (a[mid] == searchNumber)
        {
            return mid;
        } 
        if (a[mid] < searchNumber)
        {
            left=mid+1;
        }
        else
        {
            right=mid-1;
        }
    }
    return -1;
}
int [] aa = { 1, 2, 3, 4,5, 6, 8 };
var yy = binarySearch(aa, 7, 8);
Console.WriteLine(yy);
