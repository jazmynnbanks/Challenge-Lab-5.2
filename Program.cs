int[] myArray = { 9, 6, 4, 2, 3, 5, 7, 0, 1 };
int n = myArray.Length;
int expectedSum = n * (n + 1) / 2;

int actualSum = 0;

foreach (int i in myArray)
{
    actualSum += i;
}

int missingNumber = expectedSum -  actualSum;
Console.WriteLine(missingNumber);