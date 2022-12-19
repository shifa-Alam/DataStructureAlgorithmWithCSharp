
//Example();
//Example1();
Example2();
//Example3();

void Example()
{
    int a = 10, b = 20, result = 0;

    result = a + b;

    Console.WriteLine(result);

    // time complexity O(1)

}




void Example1()
{
    int n, result = 0;

    n = Convert.ToInt32(Console.ReadLine());


    result = n * (n + 1) / 2;

    Console.WriteLine(result);

    // time complexity O(1)

}


void Example2()
{
    int i, n, result = 0;

    n = Convert.ToInt32(Console.ReadLine());

    for (i = 1; i <= n; i++)
    {
        result = result + i;

    }
    Console.WriteLine(result);

    // time complexity O(n)

}


// time complexity O(n^2)
void Example3()
{
    int i, j, n, count = 0;

    n = Convert.ToInt32(Console.ReadLine());

    for (i = 0; i < n; i++)
    {
        for (j = 0; j < n; j++)
        {
            count = count + 1;
        }
    }
    Console.WriteLine(count);

    // time complexity O(n^2)

}





