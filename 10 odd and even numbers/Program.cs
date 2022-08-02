int[] oddnumbers = new int[10] {1,2,3,4,5,6,7,8,9,10 };
int sum = 0;
for (int i = 0; i < oddnumbers.Length; i++)
{
    if (oddnumbers[i] % 2 == 1)
    {
        sum += oddnumbers[i];
    };
}

Console.WriteLine(sum);
