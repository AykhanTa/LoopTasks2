// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

#region Task1
//int m = 1;
//int n = 5;
//int sum = 0;
//for(int i = m; i < n; i++)
//{
//    sum += i;
//}
//Console.WriteLine(sum);

#endregion

#region Task2
//int m = 46;
//int count = 0;
//for(int i = 1; i < m; i++)
//{
//    if (i % 15 == 0)
//    {
//        count++;
//    }
//}
//Console.WriteLine(count);
#endregion

#region Task3
int m = 100;
double sum = 0.0;
int count = 0;
for (int i = 1; i < m; i++)
{
    if (i % 21 == 0)
    {
        sum += i;
        count++;
    }
}
Console.WriteLine(sum + " " + count);
double avg = sum / count;
Console.WriteLine(avg);

#endregion

#region Task4
#endregion
